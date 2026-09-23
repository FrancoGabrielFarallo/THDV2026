using UnityEngine;

public class PlatformY : MonoBehaviour
{
    public float distancia = 10f;
    public float velocidad = 3f;

    private Vector3 posicionInicial;
    private float sentido = 1f;

    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        Vector3 movimiento = new Vector3(0, sentido, 0);
        transform.position = transform.position + movimiento * velocidad * Time.deltaTime;

        float recorrido = transform.position.y - posicionInicial.y;

        if (recorrido >= distancia)
        {
            sentido = -1f;
        }

        if (recorrido <= 0)
        {
            sentido = 1f;
        }
    }
}