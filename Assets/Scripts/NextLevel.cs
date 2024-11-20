using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            // Carga la escena de Siguiente nivel
            SceneManager.LoadScene("Next");
        }
    }

}
