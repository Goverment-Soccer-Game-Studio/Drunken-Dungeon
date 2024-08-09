using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public interface IDrink
{
    string drinkName { get; }
    Animator iAnimator { get; }
    GameObject iDrinkHolder { get; }
    PlayerData iPlayerData { get; }
    public void OnDrink() {

    }
}
