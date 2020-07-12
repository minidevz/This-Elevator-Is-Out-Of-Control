using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    //Ibrahim Hisham, Copyright Minidevs. 2019
    #region Variables


    #endregion
    private void Start ( )
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void BackToMenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
