using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    //Ibrahim Hisham, Copyright Minidevs. 2019
    #region Variables
    public GameObject elevator;

    #endregion
    private void OnCollisionEnter (Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            collision.transform.position = elevator.transform.position;
        }
    }
}
