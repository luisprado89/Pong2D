using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject ball; // Referencia al prefab de la pelota
    public GameObject player1; // Referencia al prefab del jugador 1
    public GameObject player1Goal; // Referencia al GameObject del gol del jugador 1
    public GameObject player2; // Referencia al prefab del jugador 2
    public GameObject player2Goal; // Referencia al GameObject del gol del jugador 2
    public TextMeshProUGUI player1ScoreText; // Referencia al texto del puntaje del jugador 1
    public TextMeshProUGUI player2ScoreText; // Referencia al texto del puntaje del jugador 2
    public bool AIGame; // true = juego contra la IA, false = juego contra otro jugador, para activar o desactivar la IA

    private int player1Score = 0; // Puntaje del jugador 1
    private int player2Score = 0; // Puntaje del jugador 2
    private int maxScore = 7; // Puntaje máximo para ganar el juego

    public void CheckVictory()
    {
        if (player1Score >= maxScore) // Si el jugador 1 alcanza el puntaje máximo, gana el juego
        {
            Debug.Log("¡Jugador 1 gana!");
            SceneManager.LoadScene("VictoryPlayer1"); // Carga la escena de victoria del jugador 1
        }
        else if (player2Score >= maxScore) // Si el jugador 2 alcanza el puntaje máximo, gana el juego
        {
            Debug.Log("¡Jugador 2 gana!");
            SceneManager.LoadScene("VictoryPlayer2"); // Carga la escena de victoria del jugador 2
        }
    }

    public void Player1Scored()
    {
        player1Score++; // Incrementar el puntaje del jugador 1
        player1ScoreText.text = player1Score.ToString(); // Actualizar el texto del puntaje del jugador 1
        CheckVictory(); // Verificar si hay un ganador después de que el jugador 1 anota
        ResetPosition(); // Restablecer la posición de la pelota y los jugadores
    }
    public void Player2Scored()
    {
        player2Score++; // Incrementar el puntaje del jugador 2
        player2ScoreText.text = player2Score.ToString(); // Actualizar el texto del puntaje del jugador 2
        CheckVictory(); // Verificar si hay un ganador después de que el jugador 2 anota
        ResetPosition(); // Restablecer la posición de la pelota y los jugadores
    }
    private void ResetPosition()
    {
        if (AIGame) // Si el juego es contra la IA, restablecer la posición del jugador 2 a la posición inicial de la IA
        {
            ball.GetComponent<Ball>().Reset(); // Restablecer la posición de la pelota, llamando al método Reset() del script Ball, que es publico para que pueda ser accedido desde el GameManager
            player1.GetComponent<Players>().ResetPlayer(); // Restablecer la posición del jugador 1, llamando al método ResetPlayer() del script Players, que es publico para que pueda ser accedido desde el GameManager
        }
        else // Si el juego es contra otro jugador, restablecer la posición de ambos jugadores a sus posiciones iniciales
        {
            ball.GetComponent<Ball>().Reset(); // Restablecer la posición de la pelota, llamando al método Reset() del script Ball, que es publico para que pueda ser accedido desde el GameManager
            player1.GetComponent<Players>().ResetPlayer(); // Restablecer la posición del jugador 1, llamando al método ResetPlayer() del script Players, que es publico para que pueda ser accedido desde el GameManager
            player2.GetComponent<Players>().ResetPlayer(); // Restablecer la posición del jugador 2, llamando al método ResetPlayer() del script Players, que es publico para que pueda ser accedido desde el GameManager
        }
    }
}
