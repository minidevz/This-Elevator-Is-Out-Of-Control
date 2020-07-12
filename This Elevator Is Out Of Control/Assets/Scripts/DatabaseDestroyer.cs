using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseDestroyer : MonoBehaviour
{
    //Ibrahim Hisham, Copyright Minidevs. 2019
    #region Variables
    public bool inputActive;
    public Animator destroyDatabase;
    #endregion
    private void OnTriggerEnter (Collider other)
    {
        inputActive = true;
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.E) && inputActive == true)
        {
            destroyDatabase.SetBool("destroying", true);
            this.GetComponent<DialogueIncrement>().IncrementDialogue();
            this.GetComponent<Collider>().enabled = false;
            inputActive = false;

        }
    }
}
