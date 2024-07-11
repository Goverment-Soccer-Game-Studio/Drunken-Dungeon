using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Data", menuName = "ScriptableObjectData", order = 0)]

public class PlayerData : ScriptableObject
{
    public float health;
    public float speed;
    public float jumps;
    public float jumpHeight;
    public float damage;
    public enum dmgType{
        Normal,
        Fire,
        Explosive
    }
}

