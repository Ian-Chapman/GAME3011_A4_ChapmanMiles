using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSequenceDisplay : MonoBehaviour
{
    public AudioSource audioSource;

    public GameObject seqSlot1;
    public GameObject seqSlot2;
    public GameObject seqSlot3;
    public GameObject seqSlot4;
    public GameObject seqSlot5;
    public GameObject seqSlot6;
    public GameObject seqSlot7;
    public GameObject seqSlot8;
    public GameObject seqSlot9;
    public GameObject seqSlot10;

    // Start is called before the first frame update
    void Start()
    {
        seqSlot1.SetActive(false);
        seqSlot2.SetActive(false);
        seqSlot3.SetActive(false);
        seqSlot4.SetActive(false);
        seqSlot5.SetActive(false);
        seqSlot6.SetActive(false);
        seqSlot7.SetActive(false);
        seqSlot8.SetActive(false);
        seqSlot9.SetActive(false);
        seqSlot10.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator ButtonSequence()
    {
        seqSlot1.SetActive(true);
        yield return new WaitForSeconds(.3f);
        seqSlot1.SetActive(false);

        seqSlot2.SetActive(true);
        yield return new WaitForSeconds(.3f);
        seqSlot2.SetActive(false);

        seqSlot3.SetActive(true);
        yield return new WaitForSeconds(.3f);
        seqSlot3.SetActive(false);

        seqSlot4.SetActive(true);
        yield return new WaitForSeconds(.3f);
        seqSlot4.SetActive(false);

        seqSlot5.SetActive(true);
        yield return new WaitForSeconds(.3f);
        seqSlot5.SetActive(false);

        seqSlot6.SetActive(true);
        yield return new WaitForSeconds(.3f);
        seqSlot6.SetActive(false);

        seqSlot7.SetActive(true);
        yield return new WaitForSeconds(.3f);
        seqSlot7.SetActive(false);

        seqSlot8.SetActive(true);
        yield return new WaitForSeconds(.3f);
        seqSlot8.SetActive(false);

        seqSlot9.SetActive(true);
        yield return new WaitForSeconds(.3f);
        seqSlot9.SetActive(false);

        seqSlot10.SetActive(true);
        yield return new WaitForSeconds(.3f);
        seqSlot10.SetActive(false);
    }

    public void OnShowSequenceButtonPressed()
    {
        audioSource.Play();
        StartCoroutine(ButtonSequence());
     
    }
}
