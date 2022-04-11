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

    TextMeshProUGUI outputLabel;
    // Start is called before the first frame update
    void Start()
    {
        outputLabel = GameObject.Find("OutputText").GetComponent<TextMeshProUGUI>();
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
    }
}
