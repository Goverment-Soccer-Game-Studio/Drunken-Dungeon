using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] PlayerScript playerScript;
    [SerializeField] float turnSpeed;
    [SerializeField] float moveSpeed;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Console.WriteLine("Testing...");
    }

    // Update is called once per frame
    void Update()
    {
        IfInRange();
        LocatePlayer();
        MoveTowardsPlayer();
        IfInRange();
    }

    void IfInRange()
    {
        Vector3 distance = rb.transform.position - player.transform.position;
        Console.WriteLine(distance.ToString());
        if (distance.x > 2 && distance.y > 2 && distance.z > 2)
        {
            playerScript.playerData.health -= 5;
            Console.WriteLine("Damaged Player For 5 Dmg. Player Health @ " + playerScript.playerData.health);
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
        _direction.y = 0; // Keep the enemy moving horizontally
        transform.position += (_direction * (Time.deltaTime * moveSpeed));
    }
}
