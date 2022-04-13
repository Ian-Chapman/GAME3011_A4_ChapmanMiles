using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{
    public AudioSource audioSource;
    public Light buttonLight;

    bool isLightOn = false;

    public void Start()
    {
        isLightOn = false;
        buttonLight.enabled = false;
    }

    public void OnButtonPressed()
    {
        if (!isLightOn)
        {
            isLightOn = true;
            buttonLight.enabled = true;
            audioSource.Play();
        }
        else if (isLightOn)
        {
            isLightOn = false;
            buttonLight.enabled = false;
            audioSource.Play();
        }
    }
}
