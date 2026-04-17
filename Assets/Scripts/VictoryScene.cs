using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("LoadMainMenu", 3f); // Carga el menú principal después de 3 segundos
    }

    void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Carga la escena del menú principal
    }
}
