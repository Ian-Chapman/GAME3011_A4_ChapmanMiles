using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InstructionsBehaviour : MonoBehaviour
{
    public Animator animator;
    GameManager gameManager;
    public Slider slider;
    public TextMeshProUGUI difficultyLabel;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void OnPlayButtonPressed()
    {
        animator.SetBool("instructionPlayButtonPressed", true);
        gameManager.StartGame();
        //StartGame() goes here
    }

    public void SliderChange()
    {
        switch (slider.value)
        {
            case 0:
                difficultyLabel.text = "EASY";
                gameManager.ChangeDifficutly(Difficulty.EASY);
                break;

            case 1:
                difficultyLabel.text = "MEDIUM";
                gameManager.ChangeDifficutly(Difficulty.MEDIUM);
                break;

            case 2:
                difficultyLabel.text = "HARD";
                gameManager.ChangeDifficutly(Difficulty.HARD);
                break;

            default:
                difficultyLabel.text = "EASY";
                gameManager.ChangeDifficutly(Difficulty.EASY);
                break;
        }
    }
}
