using UnityEngine;
using UnityEngine.UIElements;

public class NPC : MonoBehaviour
{
    // Variables que se pueden editar desde el Inspector de Unity
    [SerializeField] private float Velocidad = 3f;
    [SerializeField] private float Diametro = 10f;

    // Referencia al jugador (lo vamos a buscar por su Tag "Player")
    private Transform jugador;

    void Start()
    {
        // Buscamos en la escena el objeto que tenga el Tag "Player"
        GameObject objetoJugador = GameObject.FindGameObjectWithTag("Player");

        if (objetoJugador != null)
        {
            jugador = objetoJugador.transform;
        }
        else
        {
            Debug.LogWarning("No se encontro ningun objeto con el Tag 'Player'");
        }
    }

    void Update()
    {
        // Si no encontramos al jugador, no hacemos nada
        if (jugador == null) return;

        // Calculamos la distancia entre este personaje y el jugador
        float distancia = Vector3.Distance(transform.position, jugador.position);

        // Si la distancia es menor o igual al radio, perseguimos al jugador
        if (distancia <= Diametro)
        {
            // Calculamos la direccion hacia el jugador
            Vector3 direccion = (jugador.position - transform.position).normalized;

            // Movemos al personaje en esa direccion
            transform.position += direccion * Velocidad * Time.deltaTime;
        }
        // Si esta fuera del radio, no entra al if y el personaje se queda quieto
    }
    // Esto es solo para poder ver el radio en la escena (opcional, no afecta el juego)
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, Diametro);
    }

}