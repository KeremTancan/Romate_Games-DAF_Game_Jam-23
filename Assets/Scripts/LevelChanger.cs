using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public int LevelIndex;


    public void NextScene()
    {

        if (LevelIndex == 0)
        {
            SceneManager.LoadScene("Main");
        }
        if (LevelIndex == 1)
        {
            SceneManager.LoadScene("Credits");
        }
        if (LevelIndex == 2)
        {
            SceneManager.LoadScene("Entry");
        }
        if (LevelIndex == 3)
        {
            Application.Quit();
        }
    }
}