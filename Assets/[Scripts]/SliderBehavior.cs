using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SliderBehavior : MonoBehaviour, IDragHandler, IEndDragHandler
{
    bool pointerOverlap = false;
    Vector3 mousePosition;
    Image fillImage;

    Vector3 initialClick;

    public GameObject handle;

    float differenceX;
    float differenceY;

    private readonly float rotationLimit = 22.5f;
    int value = 9;

    bool dragged = false;

    // Start is called before the first frame update
    void Start()
    {
        fillImage = GetComponent<Image>();
        handle.transform.localEulerAngles = new Vector3(0, 202.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (pointerOverlap)
        {
            ////Debug.Log("pointer here");
            //mousePosition = Input.mousePosition;

            //float fillAmount = Vector3.Angle(mousePosition, new Vector3(fillImage.sprite.bounds.size.x / 2, fillImage.sprite.bounds.size.y / 2, fillImage.sprite.bounds.size.z / 2));

            //fillImage.fillAmount = fillAmount / 20;

            //Debug.Log(fillAmount);

        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 initialPress = eventData.pressPosition;



        //differenceX = initialPress.x - eventData.position.x;
        //differenceY = initialPress.y - eventData.position.y;

        if (eventData.position.x < initialPress.x && dragged == false) // move left
        {
            if(value > 0)
            {
                handle.transform.localEulerAngles = new Vector3(0, value * rotationLimit, 0);
                value--;
                dragged = true;
            }
        }

        if (eventData.position.x > initialPress.x && dragged == false) // move right
        {
            if (value < 9)
            {
                handle.transform.localEulerAngles = new Vector3(0, value * rotationLimit, 0);
                value++;
                dragged = true;
            }
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        dragged = false;
    }

    public void PointerClick()
    {
       initialClick = Input.mousePosition;
    }

    public void PointerRelease()
    {

    }


     public void PointerEnter()
     {
        pointerOverlap = true;

     }

    public void PointerExit()
    {
        pointerOverlap = false;
    }
}
