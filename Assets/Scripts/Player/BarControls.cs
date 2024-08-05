using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BarControls : MonoBehaviour
{

    bool drinkInputR;
    bool drinkInputL;
    bool confirmBool;
    [Header("Drinks")]
    [SerializeField] GameObject[] drinks;
    private int selectedDrink = 0;
    [SerializeField] Camera barCamera;
    List<GameObject> finalDrink;

    private void Update()
    {
        barCamera.transform.LookAt(drinks[selectedDrink].transform.position);
        if (drinkInputR && selectedDrink != (drinks.Length - 1))
        {
            Debug.Log("Right Drink");
            selectedDrink++;
            drinkInputR = false;
        }
        if (drinkInputL && selectedDrink != 0)
        {
            Debug.Log("Left Drink");
            selectedDrink--;
            drinkInputL = false;
        }
        if (confirmBool)
        {
            //Add UI controls stuff
            Debug.Log("Drink Selected");
            finalDrink.Add(drinks[selectedDrink].gameObject);
        }
    }

    public void RecieveInputR(bool dInput)
    {
        drinkInputR = dInput;
    }

    public void RecieveInputL(bool dInput)
    {
        drinkInputL = dInput;
    }

    public void RecieveInputConfirm(bool dInput)
    {
        confirmBool = dInput;
    }
}
