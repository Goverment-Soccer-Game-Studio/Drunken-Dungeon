using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Animator))]
public class SkeletonEnemy : MonoBehaviour, IEnemy
{

    [SerializeField] public string Name { get; set; } = "Skeleton";
    [SerializeField] public float Health { get; set; }  = 10f;
    public GameObject Player { get; set; }

    //public Image hpBar { get; set; }

    [SerializeField] float turnSpeed;

    [SerializeField] float distance;
    [SerializeField] float attackDistance;

    [SerializeField] float acceleration;
    [SerializeField] float currentSpeed;
    [SerializeField] float maxSpeed;

    public float attackCooldown = 3.0f;
    private float lastAttackTime = -Mathf.Infinity;

    private Rigidbody rb;
    private Animator animator;

    public void OnDamage(float damage)
    {
        Health -= damage;
        Debug.Log("Skeleton: " + Health);
    }
    public void OnDeath(bool hpEmpty)
    {
        Debug.Log("Skeleton has died!");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            OnDamage(Player.GetComponent<PlayerScript>().playerData.damage);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        LocatePlayer();
        MoveTowardsPlayer();
        UpdateAnimatorValues();
        IfInRange();

        if (Health <= 0)
        {
            OnDeath(true);
            Destroy(gameObject);
        }
    }

    void LocatePlayer()
    {
        Vector3 direction = (Player.transform.position - transform.position).normalized;
        direction.y = 0; // Keep the enemy upright
        Quaternion _lookRotation = Quaternion.LookRotation(direction);
        rb.transform.rotation = Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * turnSpeed);
    }

    void MoveTowardsPlayer()
    {
        Vector3 _direction = (Player.transform.position - transform.position).normalized;
        //_direction.y = 0;
        distance = Vector3.Distance(transform.position, Player.transform.position);

        if (distance > attackDistance)
        {
            currentSpeed = Math.Min(currentSpeed + (acceleration * Time.deltaTime), maxSpeed);
            transform.position += _direction * currentSpeed * Time.deltaTime;
        }
        else
        {
            currentSpeed = 0;
        }
    }

    void IfInRange()
    {
        Vector3 distance = rb.transform.position - Player.transform.position;
        if (distance.x <= attackDistance && distance.z <= attackDistance)
        {
            if (Time.time >= lastAttackTime + attackCooldown)
            {
                Attack();
                lastAttackTime = Time.time;
            }
        }
    }

    void UpdateAnimatorValues()
    {
        animator.SetFloat("Current Speed", currentSpeed);
    }

    void Attack()
    {
        Player.GetComponent<PlayerScript>().playerData.health -= 3f;
        Debug.Log("Attacked Player For 5 Dmg. Player Health: " + Player.GetComponent<PlayerScript>().playerData.health);
    }
}
