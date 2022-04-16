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
    public GameObject buttonSequence;

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
                buttonSequence.GetComponent<ButtonSequenceDisplay>().changeDelay(0.6f);
                break;

            case 1:
                difficultyLabel.text = "MEDIUM";
                gameManager.ChangeDifficutly(Difficulty.MEDIUM);
                buttonSequence.GetComponent<ButtonSequenceDisplay>().changeDelay(0.6f);
                break;

            case 2:
                difficultyLabel.text = "HARD";
                gameManager.ChangeDifficutly(Difficulty.HARD);
                buttonSequence.GetComponent<ButtonSequenceDisplay>().changeDelay(0.3f);
                break;

            default:
                difficultyLabel.text = "EASY";
                gameManager.ChangeDifficutly(Difficulty.EASY);
                buttonSequence.GetComponent<ButtonSequenceDisplay>().changeDelay(0.6f);
                break;
        }
    }
}
