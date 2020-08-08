using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DatabaseDestroyer : MonoBehaviour
{
    //Ibrahim Hisham, Copyright Minidevs. 2019
    #region Variables
    public bool inputActive;
    public Animator destroyDatabase;
    private int destroyCombo;
    public TextMeshProUGUI comboText;
    #endregion
    private void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Player")
        {
            inputActive = true;
            comboText.gameObject.SetActive(true);
        }
    }
    void Update()
    {
    
        if(Input.GetKeyDown(KeyCode.E) && inputActive == true)
        {
            destroyCombo++;
        }

        comboText.text = destroyCombo.ToString() + "/10";
       
        if(destroyCombo == 10)
        {
            destroyDatabase.SetBool("destroying", true);
          
            this.GetComponent<Collider>().enabled = false;
            comboText.gameObject.SetActive(false);
            inputActive = false;
            this.enabled = false;
        }
    }

}
