using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject ball; // Referencia al prefab de la pelota
    public GameObject player1; // Referencia al prefab del jugador 1
    public GameObject player1Goal; // Referencia al GameObject del gol del jugador 1
    public GameObject player2; // Referencia al prefab del jugador 2
    public GameObject player2Goal; // Referencia al GameObject del gol del jugador 2
    public TextMeshProUGUI player1ScoreText; // Referencia al texto del puntaje del jugador 1
    public TextMeshProUGUI player2ScoreText; // Referencia al texto del punt

    private int player1Score = 0; // Puntaje del jugador 1
    private int player2Score = 0; // Puntaje del jugador 2
    private int maxScore = 7; // Puntaje máximo para ganar el juego

    public void Player1Scored()
    {
        player1Score++; // Incrementar el puntaje del jugador 1
        player1ScoreText.text = player1Score.ToString(); // Actualizar el texto del puntaje del jugador 1
        ResetPosition(); // Restablecer la posición de la pelota y los jugadores
    }
    public void Player2Scored()
    {
        player2Score++; // Incrementar el puntaje del jugador 2
        player2ScoreText.text = player2Score.ToString(); // Actualizar el texto del puntaje del jugador 2
        ResetPosition(); // Restablecer la posición de la pelota y los jugadores
    }
    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset(); // Restablecer la posición de la pelota, llamando al método Reset() del script Ball, que es publico para que pueda ser accedido desde el GameManager
        player1.GetComponent<Players>().ResetPlayer(); // Restablecer la posición del jugador 1, llamando al método ResetPlayer() del script Players, que es publico para que pueda ser accedido desde el GameManager
        player2.GetComponent<Players>().ResetPlayer(); // Restablecer la posición del jugador 2, llamando al método ResetPlayer() del script Players, que es publico para que pueda ser accedido desde el GameManager
    }
}
