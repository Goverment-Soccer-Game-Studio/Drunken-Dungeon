using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] PlayerScript playerScript;

    [SerializeField] float turnSpeed;

    [SerializeField] float distance;
    [SerializeField] float attackDistance;

    [SerializeField] float acceleration;
    [SerializeField] float currentSpeed;
    [SerializeField] float maxSpeed;

    [SerializeField] Animator animator;

    public float attackCooldown = 3.0f;
    private float lastAttackTime = -Mathf.Infinity;

    Rigidbody rb;
    float rootY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Testing...");
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Current Speed", currentSpeed);
        LocatePlayer();
        MoveTowardsPlayer();
        IfInRange();
    }

    void IfInRange()
    {
        Vector3 distance = rb.transform.position - player.transform.position;
        if (distance.x >= attackDistance && distance.z >= attackDistance)
        {
            if (Time.time >= lastAttackTime + attackCooldown)
            {
                Attack();
                lastAttackTime = Time.time;
            }
        }
    }

    void LocatePlayer()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized;
        direction.y = 0; // Keep the enemy upright
        Quaternion _lookRotation = Quaternion.LookRotation(direction);
        rb.transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * turnSpeed);
    }

    void MoveTowardsPlayer()
    {
        Vector3 _direction = (player.transform.position - transform.position).normalized;
        _direction.y = 0;
        distance = Vector3.Distance(transform.position, player.transform.position);

        if (distance > attackDistance)
        {
            currentSpeed = Math.Min(currentSpeed + (acceleration * Time.deltaTime), maxSpeed);
            transform.position += _direction * currentSpeed * Time.deltaTime;
        }
        else 
        {
            currentSpeed = 0;
        }
        /*velocity += (_direction * (Time.deltaTime * moveSpeed));
        transform.position = velocity;*/
    }

    void Attack() 
    {
        playerScript.playerData.health -= 5f;
        Debug.Log("Attacked Player For 5 Dmg. Player Health: " + playerScript.playerData.health);
    }
}
