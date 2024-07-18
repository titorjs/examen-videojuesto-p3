using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource a;
    // M�todo para cargar una nueva escena por nombre
    public void LoadSceneByName(string sceneName)
    {
        if(sceneName == "MiniGame")
        {
            a.Pause();
        }
        SceneManager.LoadScene(sceneName);
    }

    // M�todo para cargar una nueva escena por �ndice
    public void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    // M�todo para salir del juego
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting"); // Esto solo se mostrar� en el editor de Unity
    }
}
