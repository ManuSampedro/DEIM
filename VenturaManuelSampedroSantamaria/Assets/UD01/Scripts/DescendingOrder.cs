using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    //Variables Globales
    public int number1;
    public int number2;
    public int number3;

    void Start()
    {
        
        DeOrder();
    }

    void DeOrder()
    {
        
        if (number1 > number2 && number2 > number3)
        {
            Debug.Log("Los números están en orden decreciente.");
        }
        else
        {
            Debug.Log("Los números NO están en orden decreciente.");
        }
    }
}
