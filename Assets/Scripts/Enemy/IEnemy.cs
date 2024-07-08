using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Enemy generic class to be derived from
public interface IEnemy
{
    public string name { get; set; }
    public float health { get; set; }

    public void OnDamage(float damage);
    public void OnDeath(float damage);
    
}
