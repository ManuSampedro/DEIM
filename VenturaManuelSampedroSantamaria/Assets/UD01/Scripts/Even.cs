using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Even : MonoBehaviour
{
    void Start()
    {
        
        EvenNumbers();
    }

    void EvenNumbers()
    {
        Debug.Log("Numeros pares entre 0 y 100:");

        for (int i = 0; i <= 100; i++)
        {
           
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }
    }
}