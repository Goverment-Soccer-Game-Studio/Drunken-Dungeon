using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestEnemy : MonoBehaviour, IEnemy
{
    public new string name { get; set; }
    public float health { get; set; }

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
        //10 is just the test number
        OnDamage(10f);
        OnDeath(health <= 0);
    }

    public void OnDamage(float damage)
    {
        Debug.Log("Dummy: ouch!");
        health -= damage;
    }

    public void OnDeath(bool h)
    {
        //Bool h is if the enemy has 0 hp, in IEnemy its called hpEmpty
        if (h)
        {
            Debug.Log("Oi me the test dummy die");
            Destroy(this.gameObject);
        }
    }
}
