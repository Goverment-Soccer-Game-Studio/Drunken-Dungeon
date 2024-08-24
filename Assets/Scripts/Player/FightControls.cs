using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightControls : MonoBehaviour
{
    //Booleans to trigger if a punch is thrown
    bool lPunch;
    bool rPunch;
    //Timers for punch cooldowns
    float lPunchTimer = 0f;
    float rPunchTimer = 0f;
    //Punch Cooldown
    [SerializeField] float punchCooldown;

    //Animation
    [Header("Animation")]
    //Using animations to get the arms to move forwards
    [SerializeField] Animator animator;
    [SerializeField] Animator rAnimator;
    [SerializeField] Animator lAnimator;

    private void Update()
    {
        //Left punch
        if (lPunch && lPunchTimer <= 0)
        {
            //Debug.Log("Left paunch");
            animator.SetTrigger("LeftPunch");
            lAnimator.SetTrigger("PunchL");
            lPunchTimer = punchCooldown;
        }
        else
        {
            lPunchTimer -= Time.deltaTime;
        }

        //Right punch
        if (rPunch && rPunchTimer <= 0)
        {
            //Debug.Log("Right paunch");
            animator.SetTrigger("RightPunch");
            rAnimator.SetTrigger("PunchR");
            rPunchTimer = punchCooldown;
        }
        else
        {
            rPunchTimer -= Time.deltaTime;
        }
    }

    public void RecieveInputL(bool punch)
    {
        lPunch = punch;
    }
    public void RecieveInputR(bool punch)
    {
        rPunch = punch;
    }
}
