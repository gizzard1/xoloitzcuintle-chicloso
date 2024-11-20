using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Variables p�blicas para definir los nombres de las escenas desde el Inspector
    public string nombreEscenaInicio = "Inicio"; // Nombre exacto de la escena de inicio
    public string nombreEscenaMenuPrincipal = "Menu principal"; // Nombre exacto de la escena de men� principal

    public void MostrarGameOver()
    {
        // L�gica para mostrar la pantalla de Game Over
        Debug.Log("Mostrando pantalla de Game Over");

        // Pausar el juego y mostrar el cursor
        Time.timeScale = 0; // Pausa el juego
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void ReiniciarJuego()
    {
        // Reinicia el juego estableciendo timeScale a 1
        Time.timeScale = 1;
        SceneManager.LoadScene(nombreEscenaInicio); // Carga la escena de inicio usando la variable
    }

    public void IrAlMenu(string NombreMenu)
    {
        SceneManager.LoadScene(NombreMenu);
    }
}

