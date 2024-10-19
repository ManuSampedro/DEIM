using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    void Start()
    {

        Three();
    }

    void Three()
    {
        Debug.Log("Numeros multiplos de 3 entre 0 y 100:");

        for (int i = 0; i <= 100; i++)
        {

            if (i % 3 == 0)
            {
                Debug.Log(i);
            }
        }
    }
}