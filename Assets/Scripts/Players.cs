using UnityEngine;
using UnityEngine.InputSystem;

public class Players : MonoBehaviour
{
    public bool player1; // true = player 1, false = player 2
    public float speed = 5f;// Velocidad de movimiento del jugador
    public Rigidbody2D rb; // Referencia al Rigidbody2D del jugador

    private float move; // Variable para almacenar el movimiento vertical del jugador
    private Vector2 startPosition; // Posición inicial del jugador
    void Start()
    {
        startPosition = transform.position; // Guardar la posición inicial del jugador
    }
    private void FixedUpdate()
    {
        //Aplicar la velocidad vertical al rigidbody del jugador
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, move * speed);
    }
    //Evento del nuevo Input System para el movimiento del jugador 1
    public void OnMovePlayer1(InputAction.CallbackContext context)
    {
        if (player1) // Verificar si es el jugador 1
        {
            move = context.ReadValue<Vector2>().y; // Leer el valor del movimiento vertical
        }
    }
    //Evento del nuevo Input System para el movimiento del jugador 2
    public void OnMovePlayer2(InputAction.CallbackContext context)
    {
        if (!player1) // Verificar si es el jugador 2
        {
            move = context.ReadValue<Vector2>().y; // Leer el valor del movimiento vertical
        }
    }

    public void ResetPlayer()
    {
        rb.linearVelocity = Vector2.zero;// Detener el movimiento del jugador
        transform.position = startPosition;// Restablecer la posición del jugador a la posición inicial
    }
}
