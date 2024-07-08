using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemy : MonoBehaviour, IEnemy
{
    public new string name { get; set; }
    public float health { get; set; }

    [SerializeField]

    // Start is called before the first frame update
    void Start()
    {
        health = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //The player's fists are triggers, so the OnTriggerEnter function will handle when the enemy is hit.
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        health -= 10f;
    }

    public void OnDamage(float damage)
    {
        Debug.Log("Dummy: ouch!");
    }

    public void OnDeath(float damage)
    {
        
    }
}
