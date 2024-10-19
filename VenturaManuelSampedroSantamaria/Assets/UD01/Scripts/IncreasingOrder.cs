using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    //Variables Globales
    public int number1;
    public int number2;
    public int number3;

    void Start()
    {
        //Llama al metodo
        InOrder();
    }

    void InOrder()
    {
        //Condicional que compara el numero 1 con el 2 y el 3 para saber si esta en orden creciente o no
        if (number1 < number2 && number2 < number3)
        {
            Debug.Log("Los números están en orden creciente.");
        }
        else
        {
            Debug.Log("Los números NO están en orden creciente.");
        }
    }
}
