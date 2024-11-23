using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    void Start()
    {

        TwoThree();
    }

    void TwoThree()
    {
        Debug.Log("Numeros multiplos de 2 y de 3 entre 0 y 100:");

        for (int i = 0; i <= 100; i++)
        {

            if (i % 2 == 0 && i % 3 == 0)
            {
                Debug.Log(i);
            }

        }
    }
}