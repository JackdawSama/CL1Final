using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");            //loads the Main Menu scene
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Spell Practice");       //loads the Spell Practice scene
    }
}
