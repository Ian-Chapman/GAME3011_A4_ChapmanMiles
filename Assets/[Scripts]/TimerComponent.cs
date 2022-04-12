using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TimerComponent : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    //public TextMeshPro overWorldTimerText;
    //public float overWorldTimeLeft;
    public float timeLeft;

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        timerText.text = timeLeft.ToString();

        if (timeLeft <= 0)
        {
            //reset all switches or trigger a lose state
            Time.timeScale = 0;
        }
    }
}