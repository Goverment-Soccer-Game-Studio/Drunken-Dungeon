using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarControls : MonoBehaviour
{

    Vector2 drinkInput;
    [Header("Drinks")]
    [SerializeField] GameObject[] drinks;
    private int selectedDrink = 0;
    [SerializeField] Camera barCamera;

    private void Update()
    {
        barCamera.transform.LookAt(drinks[selectedDrink].transform.position);
        if (drinkInput.x > 0)
        {
            Debug.Log("Right Drink");
            selectedDrink++;
        }
    }

    public void RecieveInput(Vector2 dInput)
    {
        drinkInput = dInput;
    }
}
