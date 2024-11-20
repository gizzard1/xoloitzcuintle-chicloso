using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Inicio");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Saliendo del juego");
    }
}