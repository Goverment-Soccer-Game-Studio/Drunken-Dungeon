using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Enemy generic class to be derived from
//Each enemy requires a rigidbody for combat, but cannot do [RequireComponent]
public interface IEnemy
{
    string Name { get; set; }
    float Health { get; set; }

    //public Image hpBar { get; set; }

    public void OnDamage(float damage);
    public void OnDeath(bool hpEmpty);
    
}
