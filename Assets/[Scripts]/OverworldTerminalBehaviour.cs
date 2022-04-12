using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverworldTerminalBehaviour : MonoBehaviour
{
    public Camera mainCamera;
    public Camera playerCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            mainCamera.enabled = true;
            playerCamera.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            mainCamera.enabled = false;
            playerCamera.enabled = true;
           
        }
    }
}
