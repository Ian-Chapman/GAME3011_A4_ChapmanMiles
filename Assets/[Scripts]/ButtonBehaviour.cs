using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject buttonLight;

    bool isLightOn = false;

    public void Start()
    {
        isLightOn = false;
        buttonLight.SetActive(false);
    }

    public void OnButtonPressed()
    {
        if (!isLightOn)
        {
            isLightOn = true;
            buttonLight.SetActive(true);
            audioSource.Play();
        }
        else if (isLightOn)
        {
            isLightOn = false;
            buttonLight.SetActive(false);
            audioSource.Play();
        }
    }
}
