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
    float timeLeft = 0;
    bool difficultyChosen = false;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (difficultyChosen)
        {
            timeLeft -= Time.deltaTime;

            timerText.text = timeLeft.ToString();

            if (timeLeft <= 0)
            {
                GameManager.gameLose = true;
                Time.timeScale = 0;
            }
        }
    }

   public void setTimeLimit(float time)
    {
        timeLeft = time;
        difficultyChosen = true;
    }
}