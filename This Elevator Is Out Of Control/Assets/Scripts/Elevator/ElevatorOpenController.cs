using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorOpenController : MonoBehaviour
{
    //Ibrahim Hisham, Copyright Minidevs. 2019
    #region Variables


  
    public List<ElevatorOpener> doorTriggers;

    private Animator doorAnimator;
    private bool openDoor = false;
  

    #endregion


    void Start ( )
    {
        doorAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update ( )
    {
        foreach(ElevatorOpener d in doorTriggers)
        {
            if(d.Events == ElevatorOpener.DoorEvents.PlayerDetected)
            {
                if(!openDoor)
                {
                    openDoor = true;
                }
                break;
            }
            else
            {
                if(openDoor)
                {
                    openDoor = false;
                }
            }
            Debug.Log(openDoor);
        }

        doorAnimator.SetBool("openDoor", openDoor);
    }
}
