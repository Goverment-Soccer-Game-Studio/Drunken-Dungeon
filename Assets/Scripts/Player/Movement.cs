using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Player Controls and Speed
    [Header("Controls")]
    [SerializeField] CharacterController controller;
    [SerializeField] float playerSpeed = 3f;
    Vector2 wasdInput;

    //Player Gravity and Jumping
    [Header("Gravity/Jumping")]
    [SerializeField] float jumpHeight = 3f;
    bool jumped = false;
    [SerializeField] float gravity = -9.81f;
    //Vertical Velocity
    Vector3 vVelocity = Vector3.zero;
    [SerializeField] LayerMask groundMask;
    bool isGrounded;

    private void Update()
    {
        //Horizontal Velocity
        Vector3 hVelocity = (transform.right * wasdInput.x + transform.forward * wasdInput.y) * playerSpeed;
        controller.Move(hVelocity * Time.deltaTime);

        //Checks if the Physics sphere is collided with the ground and returns a variable
        isGrounded = Physics.CheckSphere(transform.position, 0.1f, groundMask);
        if (isGrounded)
        {
            //If grounded do not apply gravity
            vVelocity.y = 0;
        }

        //Jumping mechanic before gravity is applied
        if (jumped)
        {
            if (isGrounded)
            {
                vVelocity.y = Mathf.Sqrt(-2 * jumpHeight * gravity);
            }
            jumped = false;
        }

        vVelocity.y += gravity * Time.deltaTime;
        controller.Move(vVelocity * Time.deltaTime);
    }

    public void RecieveInput(Vector2 wasdInputP)
    {
        wasdInput = wasdInputP;
    }

    public void OnJumpPressed()
    {
        jumped = true;
    }
}
