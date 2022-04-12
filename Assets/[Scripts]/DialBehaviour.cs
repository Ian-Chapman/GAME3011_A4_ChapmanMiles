using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialBehaviour : MonoBehaviour
{
    [SerializeField]
    public GameObject handle;
    Slider knobSlider;
    Vector3 mousePos;
    private readonly float rotationLimit = 22.5f;

    GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        knobSlider = GetComponentInChildren<Slider>();
    }

    Vector3 mousePressPoint;
    public void RotateHandle(float value)
    {
        Debug.Log("rotatehandlefunccalled");
        gameManager.changeNumber(value, gameObject.tag.Length);
    }
}
