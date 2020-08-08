using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorStopper : MonoBehaviour
{
    //Ibrahim Hisham, Copyright Minidevs. 2019
    #region Variables
    public ElevatorController elevatorController;
    public bool Stopping = true;
    #endregion

    private void OnTriggerEnter (Collider other)
    {
        if(Stopping == true)
        {
            if(other.tag == "Player")
            {
                elevatorController.onElevator = false;
                elevatorController.GetComponent<AudioSource>().Stop();
                elevatorController.gameObject.GetComponent<Collider>().enabled = false;
            }
        } else
        {
            elevatorController.gameObject.GetComponent<Collider>().enabled = true;
            this.GetComponent<DialogueIncrement>().IncrementDialogue();
        }
    }



}
