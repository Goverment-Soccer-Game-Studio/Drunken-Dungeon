using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyUI : MonoBehaviour
{
    [SerializeField] Image healthBar;
    private IEnemy enemy;

    private void Awake()
    {
        enemy = gameObject.GetComponent<IEnemy>();
    }

    private void Update()
    {
        healthBar.fillAmount = enemy.health / 100f;
    }
}
