using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorOpener : MonoBehaviour
{
    //Ibrahim Hisham, Copyright Minidevs. 2019
    #region Variables
    public AudioSource openDoorSound;
    public AudioSource closeDoorSound;

    #endregion
    public enum DoorEvents
    {
        None,
        PlayerDetected,
    };

    private DoorEvents events = DoorEvents.None;

    public void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Player")
        {
            events = DoorEvents.PlayerDetected;
            openDoorSound.Play();

            if(this.GetComponent<DialogueIncrement>() != null)
            {
                this.GetComponent<DialogueIncrement>().IncrementDialogue();

            }
        }
    }

    public void OnTriggerExit (Collider other)
    {
        if(other.tag == "Player")
        {
            events = DoorEvents.None;
            closeDoorSound.Play();
        }
    }

    public DoorEvents Events
    {
        get {return events;}
    }

}
