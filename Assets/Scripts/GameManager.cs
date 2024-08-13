using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] public GameObject Player;
    [SerializeField] PlayerScript PlayerScript;
    [SerializeField] float AreaNumber = 0;

    private static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        GetPlayer();
    }

    void Update()
    {
        if (PlayerScript.playerData.health <= 0)
        {
            Debug.Log("Player Has Died!");
            SceneManager.LoadScene("RoomStart");
            PlayerScript.playerData.health = 25;
            PlayerScript.playerData.maxHealth = 25;

            GetPlayer();
        }
    }

    public void GetPlayer()
    {
        Player = GameObject.Find("Player");
        if (Player != null)
        {
            PlayerScript = Player.GetComponent<PlayerScript>();
        }

        if (SceneManager.GetActiveScene().name != "RoomStart")
        {
            Player.transform.position = GameObject.Find("Spawn Point").transform.position;
        }
    }
}
