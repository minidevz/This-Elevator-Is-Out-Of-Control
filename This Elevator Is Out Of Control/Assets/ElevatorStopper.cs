using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorStopper : MonoBehaviour
{
    //Ibrahim Hisham, Copyright Minidevs. 2019
    #region Variables
    public ElevatorController elevatorController;

    #endregion

    private void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Player")
        {
            elevatorController.onElevator = false;
            elevatorController.gameObject.GetComponent<Collider>().enabled = false;
        }
    }



}
