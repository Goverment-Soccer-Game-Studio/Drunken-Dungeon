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
        Quaternion _lookRotation = Quaternion.LookRotation((player.transform.position - transform.position).normalized);
        rb.transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * turnSpeed);
    }

    void MoveTowardsPlayer()
    {
        Vector3 _direction = ((player.transform.position - transform.position).normalized);
        transform.position += (_direction * (Time.deltaTime * moveSpeed));
    }
}
