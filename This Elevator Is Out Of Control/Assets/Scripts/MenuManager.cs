using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
  //Ibrahim Hisham, Copyright Minidevs. 2019
   #region Variables


    #endregion
  public void PlayGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void QuitGame ( )
    {
        Application.Quit();
    }
}
