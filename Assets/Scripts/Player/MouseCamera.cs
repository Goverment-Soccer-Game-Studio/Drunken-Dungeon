using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour
{
    //Sensitivity x and sensitivity y
    [SerializeField] public float sensX = 8f;
    [SerializeField] public float sensY = 0.5f;
    float mouseX;
    float mouseY;

    [SerializeField] Transform camTransform;
    [SerializeField] float xClamp = 85f;
    //X rotation
    float xRot = 0;

    private void Update()
    {
        transform.Rotate(Vector3.up, mouseX * Time.deltaTime);
        //-= is normal, += would be inverted
        xRot -= mouseY;
        //Clamps the camera
        xRot = Mathf.Clamp(xRot, -xClamp, xClamp);
        //Gets the current rotation, stores it, then sets it to the x rotation of the camera
        Vector3 targetRot = transform.eulerAngles;
        targetRot.x = xRot;
        //Rotates the camera
        camTransform.eulerAngles = targetRot;
    }

    public void RecieveInput(Vector2 mouseInput)
    {
        mouseX = mouseInput.x * sensX;
        mouseY = mouseInput.y * sensY;
    }
}
