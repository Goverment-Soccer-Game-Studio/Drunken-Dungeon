using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyUI : MonoBehaviour
{
    [SerializeField] Image healthBar;
    [SerializeField] Image healthBarBg;
    private IEnemy enemy;
    Camera mainCam;

    private void Awake()
    {
        enemy = gameObject.GetComponent<IEnemy>();
        mainCam = Camera.main;
    }

    private void Update()
    {
        healthBar.fillAmount = enemy.health / 100f;
        BillboardHP(healthBar);
        BillboardHP(healthBarBg);
    }

    private void BillboardHP(Image img)
    {
        img.gameObject.transform.LookAt(mainCam.transform.position);
        img.gameObject.transform.Rotate(0, 180, 0);
    }
}
