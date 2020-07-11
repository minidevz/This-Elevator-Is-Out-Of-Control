using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue 
{
    //Ibrahim Hisham, Copyright Minidevs. 2019
    #region Variables
    [Multiline(3)]
    public string dialogueMessage;
    public float messageDuration;
    public bool consecutiveMessage;

    #endregion
 
}
