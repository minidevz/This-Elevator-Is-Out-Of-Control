﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggers : MonoBehaviour
{
  //Ibrahim Hisham, Copyright Minidevs. 2019
   #region Variables


    #endregion
    void Start()
    {
        
    }

    private void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Player")
        {

            this.GetComponent<DialogueIncrement>().IncrementDialogue();
        }
     
       

    }
    private void OnTriggerExit (Collider other)
    {
        if(other.tag == "Player")
        {
            this.GetComponent<Collider>().enabled = false;
        }
    }
}
