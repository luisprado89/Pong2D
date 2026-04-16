using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool player1Goal; // true = gol del jugador 1, false = gol del jugador 2
    public GameObject gameManager; // Referencia al GameManager para actualizar el puntaje


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Si lo que entra en la portería es la pelota
        if (collision.CompareTag("Ball"))
        {
            Debug.Log("¡Gol!");

            // Si la pelota entra en la portería del jugador 1, marca el jugador 2
            if (player1Goal)
            {
                gameManager.GetComponent<GameManager>().Player2Scored();
            }
            else
            {
                // Si entra en la portería del jugador 2, marca el jugador 1
                gameManager.GetComponent<GameManager>().Player1Scored();
            }
        }
    }
}