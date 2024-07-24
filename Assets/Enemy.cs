using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float turnSpeed;
    [SerializeField] float moveSpeed;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        LocatePlayer();
        MoveTowardsPlayer();
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
