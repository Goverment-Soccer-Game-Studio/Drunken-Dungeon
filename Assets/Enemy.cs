using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float turnSpeed;
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
    }

    void LocatePlayer()
    {
        Quaternion _lookRotation = Quaternion.LookRotation((player.transform.position - transform.position).normalized);
        //Quaternion _lookRotation = Quaternion.LookRotation((rb.transform.position - player.transform.position).normalized);
        rb.transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * turnSpeed);
    }
}
