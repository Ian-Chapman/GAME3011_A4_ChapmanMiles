using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Light[] buttonLights;

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

    Light OutputDialRed;
    Light OutputDialGreen;

    Light OutputTopButtonRed;
    Light OutputTopButtonGreen;
    Light OutputBottomButtonRed;
    Light OutputBottomButtonGreen;


    AudioSource correct;

    bool numbersWon = false;
    bool topSwitchWon = false;
    bool bottomSwitchWon = false;

    TextMeshProUGUI outputLabel;

    // Start is called before the first frame update
    void Start()
    {
        outputLabel = GameObject.Find("OutputText").GetComponent<TextMeshProUGUI>();
        winNumber = Random.Range(10000, 99999);

        OutputDialRed = GameObject.Find("OutputRedCyl").GetComponentInChildren<Light>();
        OutputDialGreen = GameObject.Find("OutputGreenCyl").GetComponentInChildren<Light>();

        OutputTopButtonRed = GameObject.Find("UpArrowRedCyl").GetComponentInChildren<Light>();
        OutputTopButtonGreen = GameObject.Find("UpArrowGreenCyl").GetComponentInChildren<Light>();
        OutputBottomButtonRed = GameObject.Find("LeftArrowRedCyl").GetComponentInChildren<Light>();
        OutputBottomButtonGreen = GameObject.Find("LeftArrowGreenCyl").GetComponentInChildren<Light>();

        correct = GetComponent<AudioSource>();

        NumberDisplayOnStart();

        tenThousandNum.text = displayTenThousandNum.ToString();
        oneThousandNum.text = displayOneThousandNum.ToString();
        oneHundredNum.text = displayOneHundredNum.ToString();
        tenNum.text = displayTenNum.ToString();
        oneNum.text = displayOneNum.ToString();

        foreach (Light light in buttonLights)
        {
            light.enabled = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        TopButtonRowWon();
        BottomButtonRowWon();
        OtherTopButtons();
        OtherBottomButtons();
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
                OutputDialGreen.enabled = true;
                OutputDialRed.enabled = false;
                numbersWon = true;
                correct.Play();
            }

            else
            {
                OutputDialGreen.enabled = false;
                OutputDialRed.enabled = true;
                numbersWon = false;
            }
        }
        else
        {
            numbersWon = false;
            OutputDialRed.enabled = true;
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


    public void TopButtonRowWon()
    {
        if ((buttonLights[0].enabled == true) &&
            (buttonLights[1].enabled == true) &&
            (buttonLights[7].enabled == true) &&
            (buttonLights[8].enabled == true) &&
            (buttonLights[4].enabled == true))
        {
            OutputTopButtonRed.enabled = false;
            OutputTopButtonGreen.enabled = true;
            topSwitchWon = true;
            //correct.Play();
            Debug.Log("Top button row won");
        }
        else
        {
            OutputTopButtonRed.enabled = true;
            OutputTopButtonGreen.enabled = false;
        }
    }

    public void BottomButtonRowWon()
    {
        if ((buttonLights[15].enabled == true) &&
            (buttonLights[11].enabled == true) &&
            (buttonLights[17].enabled == true) &&
            (buttonLights[18].enabled == true) &&
            (buttonLights[14].enabled == true))
        {
            OutputBottomButtonRed.enabled = false;
            OutputBottomButtonGreen.enabled = true;
            bottomSwitchWon = true;
            //correct.Play();
            Debug.Log("Bottom button row won");
        }
        else
        {
            OutputBottomButtonRed.enabled = true;
            OutputBottomButtonGreen.enabled = false;
        }
    }

    public void OtherTopButtons()
    {
        if ((buttonLights[5].enabled == true) ||
            (buttonLights[6].enabled == true) ||
            (buttonLights[2].enabled == true) ||
            (buttonLights[3].enabled == true) ||
            (buttonLights[9].enabled == true)) 
        {
            topSwitchWon = false;
            OutputTopButtonRed.enabled = true;
            OutputTopButtonGreen.enabled = false;
            Debug.Log("You have an incorrect button pressed...");
        }
    }

    public void OtherBottomButtons()
    {
        if ((buttonLights[10].enabled == true) ||
            (buttonLights[16].enabled == true) ||
            (buttonLights[12].enabled == true) ||
            (buttonLights[13].enabled == true) ||
            (buttonLights[19].enabled == true))
        {
            bottomSwitchWon = false;
            OutputBottomButtonRed.enabled = true;
            OutputBottomButtonGreen.enabled = false;
            Debug.Log("You have an incorrect button pressed...");
        }
    }

}
