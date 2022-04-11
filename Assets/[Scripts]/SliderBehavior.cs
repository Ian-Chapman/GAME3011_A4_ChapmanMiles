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
    public GameObject dial;

    float deadzone;
    float differenceY;
    float deadzoneInitialPress;

    private readonly float rotationLimit = 22.5f;
    int value = 0;

    AudioSource click;

    bool dragged = false;
    Vector2 initialPress;

    // Start is called before the first frame update
    void Start()
    {
        fillImage = GetComponent<Image>();
        handle.transform.localEulerAngles = new Vector3(0, 0, 0);

        click = GetComponent<AudioSource>();
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
        initialPress = eventData.pressPosition;

        if (eventData.position.x < initialPress.x && dragged == false) // move left
        {
            Debug.Log("reached deadzone");
            Debug.Log("Deadzone: " + deadzone + "Deadzone distance: " + deadzoneInitialPress);
            if (value > 0)
            {
                value--;
                transform.parent.gameObject.GetComponent<DialBehaviour>().RotateHandle(value);
                handle.transform.localEulerAngles = new Vector3(0, value * rotationLimit, 0);
                click.pitch -= 0.05f;
                click.Play();
                dragged = true;
                StartCoroutine(numberDecreaseCooldown(0.1f));
            }
        }

        if (eventData.position.x > initialPress.x && dragged == false) // move right
        {
            if (value < 9 && value > 0)
            {
                value++;
                transform.parent.gameObject.GetComponent<DialBehaviour>().RotateHandle(value);
                handle.transform.localEulerAngles = new Vector3(0, value * rotationLimit, 0);
                click.pitch += 0.05f;
                click.Play();
                dragged = true;
                StartCoroutine(numberDecreaseCooldown(0.1f));
            }

            if(value == 0)
            {
                value++;
                transform.parent.gameObject.GetComponent<DialBehaviour>().RotateHandle(value);
                handle.transform.localEulerAngles = new Vector3(0, 22.5f, 0);
                click.pitch += 0.05f;
                click.Play();
                dragged = true;
                Debug.Log(value);
                StartCoroutine(numberDecreaseCooldown(0.1f));
            }
        }

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        dragged = false;


        
    }

    public void PointerClick()
    {
       initialPress =  Input.mousePosition;
       deadzoneInitialPress = initialClick.x;
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

    IEnumerator numberDecreaseCooldown(float cooldown)
    {
        yield return new WaitForSeconds(cooldown);
        dragged = false;
    }
}
