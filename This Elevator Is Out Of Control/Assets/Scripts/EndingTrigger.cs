using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingTrigger : MonoBehaviour
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
            other.GetComponent<Animator>().enabled = true;
         
        }
    }


}
