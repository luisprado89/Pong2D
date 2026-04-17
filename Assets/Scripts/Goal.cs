using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isLeftGoal;// Indica si este gol es el gol izquierdo (jugador 1) o el gol derecho (jugador 2)
    public GameObject gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            if (isLeftGoal)// Si el gol es el gol izquierdo, el jugador 2 anota
            {
                gameManager.GetComponent<GameManager>().Player2Scored();
                Debug.Log("¡Jugador 2 anota!");
            }
            else// Si el gol es el gol derecho, el jugador 1 anota
            {
                gameManager.GetComponent<GameManager>().Player1Scored();
                Debug.Log("¡Jugador 1 anota!");
            }
        }
    }
}