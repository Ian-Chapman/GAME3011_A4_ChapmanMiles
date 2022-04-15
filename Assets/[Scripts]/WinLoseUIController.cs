using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLoseUIController : MonoBehaviour
{
    public void OnReplayRetryButtonPressed()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OnQuitButtonPressed()
    {
        Application.Quit();
    }

}
