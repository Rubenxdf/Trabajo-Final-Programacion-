using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToPanel : MonoBehaviour
{
    void Update()
    {
        // Detecta si el usuario presiona la tecla "Esc"
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Cambia a la escena del panel
            SceneManager.LoadScene("mainMenu"); // Reemplaza con el nombre de tu escena del panel
        }
    }
}
