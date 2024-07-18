using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource a;
    // Método para cargar una nueva escena por nombre
    public void LoadSceneByName(string sceneName)
    {
        if(sceneName == "MiniGame")
        {
            a.Pause();
        }
        SceneManager.LoadScene(sceneName);
    }

    // Método para cargar una nueva escena por índice
    public void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    // Método para salir del juego
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting"); // Esto solo se mostrará en el editor de Unity
    }
}
