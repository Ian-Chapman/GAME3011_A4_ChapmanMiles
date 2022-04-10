using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialBehaviour : MonoBehaviour
{
    [SerializeField]
    public GameObject handle;
    public Slider knobSlider;
    Vector3 mousePos;
    private readonly float rotationLimit = 22.5f;

    Vector3 mousePressPoint;
    public void RotateHandle()
    {
        //handle.transform.localEulerAngles = new Vector3(0, knobSlider.value * rotationLimit, 0);
        handle.transform.localEulerAngles = new Vector3(0, (mousePos.x * rotationLimit), 0);

        Mathf.Clamp(handle.transform.localEulerAngles.y, 0, 202.5f);

    }

    void Update()
    {
        mousePos = Input.mousePosition;
        //Debug.Log(handle.transform.localEulerAngles);
        //if(handle.transform.localEulerAngles.y >= 0 && handle.transform.localEulerAngles.y <= 202.5)
        //{

        //}

        if (Input.GetMouseButtonDown(0))
        {
            mousePressPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(0))
        {
            RotateHandle();
        }

       
       


    }

    void OnMouseDrag()
    {
        RotateHandle();
    }

    private void OnMouseDown()
    {
        Debug.Log("yes");
    }
}
