using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public void playGame()
    {
        SceneManager.LoadSceneAsync("GameScene");
    }

    public void optMenu()
    {
        SceneManager.LoadSceneAsync("Options Menu");
    }

    public void quitGame()
    {
        Application.Quit();
    }


}
