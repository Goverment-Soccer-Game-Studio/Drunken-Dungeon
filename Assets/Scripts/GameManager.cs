using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] PlayerScript PlayerScript;
    [SerializeField] float AreaNumber = 0;

    void Update()
    {
        if (PlayerScript.playerData.health <= 0)
        {
            Debug.Log("Player Has Died!");
            SceneManager.LoadScene("RoomStart");
            PlayerScript.playerData.health = 50;
        }
    }

    
}
