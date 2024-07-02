using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightControls : MonoBehaviour
{
    //Booleans to trigger if a punch is thrown
    bool lPunch;
    bool rPunch;
    float punchTimer = 0f;
    [SerializeField] float punchIFrames;

    //Arm objects
    [SerializeField] GameObject leftArmObj;
    [SerializeField] GameObject rightArmObj;

    private void Update()
    {
        //Left punch
        if (lPunch)
        {
            Debug.Log("Left paunch");
            ChangeArm(rightArmObj, new Vector3(10f, 10f, 10f));
            punchTimer = punchIFrames;
        }
        else
        {
            punchTimer -= Time.deltaTime;
            if (punchTimer < 0f)
            {
                ChangeArm(rightArmObj, Vector3.one);
            }
        }

        //Right punch
        if (rPunch)
        {
            Debug.Log("Right paunch");
            ChangeArm(leftArmObj, new Vector3(10f, 10f, 10f));
            punchTimer = 0.5f;
        }
        else
        {
            punchTimer -= Time.deltaTime;
            if (punchTimer < 0f)
            {
                ChangeArm(leftArmObj, Vector3.one);
            }
        }
    }

    //Test input for paunching
    private void ChangeArm(GameObject arm, Vector3 scale)
    {
        arm.transform.localScale = scale;
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
