using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 7f; // Velocidad de la pelota
    public Rigidbody2D rb; // Referencia al Rigidbody2D de la pelota
    private Vector2 startPosition; // Posición inicial de la pelota
    void Start()
    {
        startPosition = transform.position; // Guardar la posición inicial de la pelota
        Launch(); // Lanzar la pelota al inicio del juego
    }
    public void Reset()
    {
        transform.position = startPosition; // Restablecer la posición de la pelota a la posición inicial
        rb.linearVelocity = Vector2.zero; // Detener el movimiento de la pelota
        Launch(); // Lanzar la pelota nuevamente
    }

    public void Launch()
    {
        // Lanzar la pelota en una dirección aleatoria
        float x = Random.Range(0, 2) == 0 ? -1 : 1; // Dirección horizontal aleatoria
        float y = Random.Range(0, 2) == 0 ? -1 : 1; // Dirección vertical aleatoria
        rb.linearVelocity = new Vector2(speed * x, speed * y); // Aplicar la velocidad a la pelota
    }
}
