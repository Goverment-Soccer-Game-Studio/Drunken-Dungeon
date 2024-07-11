using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyUI : MonoBehaviour
{
    [SerializeField] Image healthBar;
    [SerializeField] private IEnemy enemy;

    private void Start()
    {
        enemy = gameObject.GetComponent<IEnemy>();
        Instantiate(healthBar);
    }

    private void Update()
    {
        healthBar.fillAmount = enemy.health / 100f;
    }
}
