using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    //Ibrahim Hisham, Copyright Minidevs. 2019
    #region Variables
    public Dialogue[] dialogues;
    public TextMeshProUGUI dialogueText;
    private Dialogue currentDialogue;
    [HideInInspector]
    public int index = 0;


    #endregion
    void Start()
    {
        currentDialogue = dialogues[index];
    }

    void Update()
    {
        currentDialogue = dialogues[index];

        dialogueText.text = currentDialogue.dialogueMessage;
        dialogueText.color = currentDialogue.textColor;
    }

  
}
