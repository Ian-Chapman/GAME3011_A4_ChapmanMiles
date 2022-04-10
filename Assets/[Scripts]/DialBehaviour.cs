using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialBehaviour : MonoBehaviour
{
    [SerializeField]
    public GameObject handle;
    public Slider knobSlider;

    private readonly float rotationLimit = 22.5f;

    public void RotateHandle()
    {
        handle.transform.localEulerAngles = new Vector3(0, knobSlider.value * rotationLimit, 0);

        

    }
}
