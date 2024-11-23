using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{
    //Variables Globales
    public int number1;
    public int number2;
    public int number3;

    void Start()
    {
        // Llama al metodo
        ShowNumbersInOrder();
    }

    void ShowNumbersInOrder()
    {
        
        int largest, middle, smallest;

        

        
        if (number1 < number2 && number1 < number3)
        {
            
            smallest = number1;

            
            if (number2 <= number3)
            {
                
                middle = number2;
                largest = number3;

            }
            else
            {
                
                middle = number3;
                largest = number2;

            }

        }
        
        else if (number2 < number1 && number2 < number3)
        {
            
            smallest = number2;

            
            if (number1 <= number3)
            {
                
                middle = number1;
                largest = number3;

            }
            else
            {
                
                middle = number3;
                largest = number1;

            }

        }
        else
        {
            
            smallest = number3;

            
            if (number1 <= number2)
            {
                
                middle = number1;
                largest = number2;

            }
            else
            {
                
                middle = number2;
                largest = number1;

            }
        }

        
        Debug.Log("Los numeros asignados de menor a mayor son: " + largest + "," + middle + "," + smallest);
    }
}
