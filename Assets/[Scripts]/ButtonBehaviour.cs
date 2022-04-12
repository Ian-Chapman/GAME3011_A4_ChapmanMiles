using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    public GameObject upButtonLight;
    public GameObject downButtonLight;

    bool upLightOn = false;
    bool downLightOn = false;

    public void Start()
    {
        //upButtonLight.SetActive(false);
        //downButtonLight.SetActive(false);
    }

    public void OnUpButtonPressed()
    {
        //downLightOn = false;

        //if (downLightOn == false)
        //{
            upButtonLight.SetActive(true);
           // upLightOn = true;
       // }
    }

    public void OnDownButtonPressed()
    {
        upLightOn = false;

        if (upLightOn == false)
        {
            downButtonLight.SetActive(true);
            downLightOn = true;
        }
        
    }
}
