using UnityEngine;

public class AI : MonoBehaviour
{
    public float speed = 3; // Velocidad con la que se moverá la IA
    public GameObject ball; // Referencia al GameObject de la pelota
    private Vector2 ballPos; // Almacena la posición de la pelota

    void Update()
    {
        Move(); // Llama al método Move cada frame
    }

    void Move()
    {
        ballPos = ball.transform.position; // Obtiene la posición actual de la pelota

        // Si la posición Y de la IA es mayor que la de la pelota, baja
        if (transform.position.y > ballPos.y)
        {
            transform.position += new Vector3(0, -speed * Time.deltaTime); // Mover hacia abajo
        }

        // Si la posición Y de la IA es menor que la de la pelota, sube
        if (transform.position.y < ballPos.y)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime); // Mover hacia arriba
        }
    }
}