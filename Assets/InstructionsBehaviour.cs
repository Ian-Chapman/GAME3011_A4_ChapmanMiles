using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsBehaviour : MonoBehaviour
{
    public Animator animator;

    public void OnPlayButtonPressed()
    {
        animator.SetBool("instructionPlayButtonPressed", true);
        //StartGame() goes here
    }
}
