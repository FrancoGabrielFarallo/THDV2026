
using System.Collections;
using UnityEngine;


public class Clase2 : MonoBehaviour
{

    string name = "Franco Gabriel Farallo";
    int age = 24;
    string birthDate = "25/12/2001";

    bool verdad = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hola");

        Debug.Log(name);
        Debug.Log(age);
        Debug.Log(birthDate);
        Debug.Log(name + " " + age + " " + birthDate);

        Debug.Log($"Edad 1: {age}");


        if (age == 24)
        {
            age = 30;
        }

        int age2 = 1;

        if (verdad == false)
        {
            age2 = age + 2;
        }


        Debug.Log(age);

        Debug.Log(age2);

    }

    // Update is called once per frame
    void Update()
    {

        

    }

    

}
