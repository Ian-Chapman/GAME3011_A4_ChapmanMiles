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
    GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (difficultyChosen)
        {
            timeLeft -= Time.deltaTime;

            timerText.text = timeLeft.ToString();

            if (timeLeft <= 0 && gameManager.gameLose == false)
            {
                gameManager.gameLose = true;
                gameManager.OnPlayerLose();
              
                
            }
        }
    }

   public void setTimeLimit(float time)
    {
        timeLeft = time;
        difficultyChosen = true;
    }
}