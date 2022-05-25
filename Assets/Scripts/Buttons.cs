using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
   public void tryAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }

    

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
}
