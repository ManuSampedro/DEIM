using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    //Variables Globales

    public int number;

    void Start()
    {
        //Llama al metodo
        Add();
    }


    void Add()
    {
        int total = 0;  

        
        for (int i = 1; i <= number; i++)
        {
            total += i;  
        }

        
        Debug.Log("La suma de los n�meros del 1 al " + number + " es: " + total);
    }
}
