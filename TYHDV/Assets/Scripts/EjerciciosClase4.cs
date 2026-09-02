using System.Collections;
using UnityEngine;



public class EjerciciosClase4 : MonoBehaviour
{

    float timer = 0;

    int segundos = 0;

    int duracion = 10;

    bool terminar = false;

    float segundosRestantes = 10;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //time();
        LogicaCuentaRegresiva();
    }


    void time()
    {

        timer += Time.deltaTime;

        if (timer >= 1 && duracion > 0)
        {

            duracion--;

            segundos++;


            Debug.Log("Segundo: " + segundos);

            timer = 0;

        }

        if (duracion == 0 && terminar == false)
        {
            terminar = true;

            Debug.Log("Terminado");

        }
    }


    void LogicaCuentaRegresiva()
    {

        timer += Time.deltaTime;

        if (timer >= 1 && duracion >= 0)
        {

            duracion--;

            Debug.Log("Tiempo Restante: " + segundosRestantes);

            segundosRestantes--;


            

            timer = 0;

        }

        if (duracion == 0 && terminar == false && segundosRestantes == 0)
        {
            terminar = true;

            Debug.Log("Terminado");

        }



    }




}
