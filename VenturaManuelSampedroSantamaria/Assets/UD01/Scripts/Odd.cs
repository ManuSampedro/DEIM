using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odd : MonoBehaviour
{
    void Start()
    {
        //LLama la funcion
         OddNumbers();
    }

    void OddNumbers()
    {
        Debug.Log("Numeros impares entre 0 y 100:");

        //Crea un bucle "for" empezando en 0 hasta el 100 y sumando 1 cada vez que sale del bucle
        for (int i = 0; i <= 100; i++)
        {
            
            //Si i no tiene resto 0 cuando se divide entre 2, imprimimos por consola i(el numero en cuestion)
            if (i % 2 != 0)
            {
                Debug.Log(i);
            }
        }
    }
}