using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    string oneSlot = "#";
    string tenSlot = "#";
    string hundredSlot = "#";
    string thousandSlot = "#";
    string tenThousandSlot = "#";

    public int winNumber;
    string winNumberCheck;

    char displayTenThousandNum = '#';
    char displayOneThousandNum = '#';
    char displayOneHundredNum = '#';
    char displayTenNum = '#';
    char displayOneNum = '#';

    public TextMeshPro tenThousandNum;
    public TextMeshPro oneThousandNum;
    public TextMeshPro oneHundredNum;
    public TextMeshPro tenNum;
    public TextMeshPro oneNum;

    Light OutputRed;
    Light OutputGreen;

    AudioSource correct;

    bool numbersWon = false;

    TextMeshProUGUI outputLabel;

    // Start is called before the first frame update
    void Start()
    {
        outputLabel = GameObject.Find("OutputText").GetComponent<TextMeshProUGUI>();
        winNumber = Random.Range(10000, 99999);

        OutputRed = GameObject.Find("OutputRedCyl").GetComponentInChildren<Light>();
        OutputGreen = GameObject.Find("OutputGreenCyl").GetComponentInChildren<Light>();

        correct = GetComponent<AudioSource>();

        NumberDisplayOnStart();

        tenThousandNum.text = displayTenThousandNum.ToString();
        oneThousandNum.text = displayOneThousandNum.ToString();
        oneHundredNum.text = displayOneHundredNum.ToString();
        tenNum.text = displayTenNum.ToString();
        oneNum.text = displayOneNum.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeNumber(float num, int digitToChange)
    {
        Debug.Log("changeNumberFuncCalled");
        switch (digitToChange)
        {
            case 1: // 10,000
                oneSlot = num.ToString();
                break;
            case 2: // 1,000
                tenSlot = num.ToString();
                break;
            case 3: // 100
                hundredSlot = num.ToString();
                break;
            case 4: // 10
                thousandSlot = num.ToString();
                break;
            case 5: // 1
                tenThousandSlot = num.ToString();
                break;
        }
        

        outputLabel.text = tenThousandSlot + thousandSlot + hundredSlot + tenSlot + oneSlot;

        winNumberCheck = outputLabel.text;

        checkForWinNumbers();
    }

    void checkForWinNumbers()
    {
        if (!winNumberCheck.Contains("#"))
        {
            if (winNumber == int.Parse(winNumberCheck))
            {
                Debug.Log("yahoo");
                OutputGreen.enabled = true;
                OutputRed.enabled = false;
                numbersWon = true;
                correct.Play();
            }

            else
            {
                OutputGreen.enabled = false;
                OutputRed.enabled = true;
                numbersWon = false;
            }
        }
        else
        {
            numbersWon = false;
            OutputRed.enabled = true;
        }


    }

    public void NumberDisplayOnStart()
    {
        

        for (int i = 0; i < winNumber.ToString().Length; i++)
        {
            displayTenThousandNum   = winNumber.ToString()[0];
            displayOneThousandNum   = winNumber.ToString()[1];
            displayOneHundredNum    = winNumber.ToString()[2];
            displayTenNum           = winNumber.ToString()[3];
            displayOneNum           = winNumber.ToString()[4];
        }
    }
}
