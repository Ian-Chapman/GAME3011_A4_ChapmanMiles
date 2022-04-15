using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLoseUIController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEasyButtonPressed()
    {

    }

    public void OnMediumButtonPressed()
    {

    }

    public void OnHardButtonPressed()
    {

    }

    public void OnReplayRetryButtonPressed()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OnQuitButtonPressed()
    {
        Application.Quit();
    }

}
