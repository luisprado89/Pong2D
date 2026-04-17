using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class MainMenu : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {// Si se presiona la tecla Escape, salir del juego ya que tengo el menú principal en la escena, tengo el nuevo Input System, así que uso el Keyboard.current para detectar la tecla Escape
        if (Keyboard.current != null && Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Application.Quit();
        }
    }
    public void PlayerVSAI()
    {
        SceneManager.LoadScene("PlayerVSAI"); // Carga la escena del modo jugador contra IA
    }
    public void PlayerVSPlayer()
    {
        SceneManager.LoadScene("PlayerVSPlayer"); // Carga la escena del modo jugador contra jugador
    }
}
