using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float timeToSpawn;

    private void Update()
    {
        timeToSpawn -= Time.deltaTime;
        if (timeToSpawn < 0)
        {
            Instantiate(enemyPrefab, gameObject.transform);
            Destroy(this.gameObject);
        }
    }
}
