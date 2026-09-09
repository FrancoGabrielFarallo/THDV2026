using System.Collections;
using UnityEngine;



public class EjerciciosClase4 : MonoBehaviour
{

    float timer = 0;

    int segundos = 0;

    int duracion = 10;

    bool terminar = false;

    float segundosRestantes = 10;

    int[]segundosPares = new int[5];

    int posicionArray = 0;

    bool pararWhile = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time();
        //LogicaCuentaRegresiva();
    }


    void time()
    {

        timer += Time.deltaTime;

        if (timer >= 1 && duracion > 0)
        {

            duracion--;

            segundos++;

            if (segundos % 2 == 0)
            {



                segundosPares.SetValue(segundos, posicionArray);

                posicionArray++;

                //Debug.Log("Segundo: " + segundos + " es par");

            }
            //else { Debug.Log("Segundo: " + segundos); }


            timer = 0;

        }

        if (duracion == 0 && terminar == false)
        {
            terminar = true;

            Debug.Log("Terminado");

            //ArrayPares();
            MostrarParesMayoresWhile();

        }







    }


    void LogicaCuentaRegresiva()
    {

        timer += Time.deltaTime;

        if (timer >= 1 && duracion >= 0 && segundosRestantes >= 1)
        {

            duracion--;



            segundosRestantes--;


            Debug.Log("Tiempo Restante: " + segundosRestantes);



            timer = 0;

        }

        if (duracion == 0 && terminar == false && segundosRestantes == 0)
        {
            terminar = true;

            pararWhile = true;

            Debug.Log("Terminado");

        }



    }


    void ArrayPares()
    {

        for (int i = 0; i < segundosPares.Length; i++)
        {


            Debug.Log("Par: " + segundosPares[i]);

        }


    }


    void MostrarParesMayoresWhile()
    {


        while(pararWhile == false)
        {

            int i= 0; 
            i++;

            if (posicionArray >= 1)
            {

                Debug.Log("Par: " + segundosPares[i]);

            }


        }


    }








}
