using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{
    public AudioSource audioSource;
    public Light buttonLight;

    GameManager gameManager;

    bool isLightOn = false;

    public void Start()
    {
        isLightOn = false;
        buttonLight.enabled = false;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
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

        gameManager.TopButtonRowWon();
        gameManager.OtherTopButtons();
        gameManager.BottomButtonRowWon();
        gameManager.OtherBottomButtons();

    }
}
