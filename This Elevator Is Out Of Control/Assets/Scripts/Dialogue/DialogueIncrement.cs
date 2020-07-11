using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueIncrement : MonoBehaviour
{
    //Ibrahim Hisham, Copyright Minidevs. 2019
    #region Variables
    public DialogueManager dialogueManager;

    #endregion
    public void IncrementDialogue()
    {
        dialogueManager.index++;
        this.enabled = false;
    }
}
