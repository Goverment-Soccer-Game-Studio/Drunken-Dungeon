using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    [SerializeField] GameObject playerObj;
    void Start()
    {
        Instantiate(playerObj);
        Destroy(this.gameObject);
    }
}
