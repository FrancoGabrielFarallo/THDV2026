using UnityEngine;
using System.Collections;

public class Clase3 : MonoBehaviour
{

    //Clase de if, for y while


    int edad = 30;

    bool verdad = false;

    int counter = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        if (verdad == false)
            edad += 5;

        Debug.Log(edad);

        for (int i = 0; i < 5; i++)
        {

            Debug.Log("Se ejecuta");

        }

        while (verdad == false)
        {

            counter++;

            if (counter == 5)
                verdad = true;



        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
