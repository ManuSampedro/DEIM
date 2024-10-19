using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{
    //Variables Globales
    public int number1;
    public int number2;
    public int number3;

    void Start()
    {
        //Llama al metodo
        ShowNumbersInOrder();
    }

    void ShowNumbersInOrder()
    {
        //Declaramos 3 propiedades int (numeros enteros)
        int smallest, middle, largest;

        //Con condicionales ( "if", "else" y "else if") comparamos los numeros para saber cual es el orden de menor a mayor

        //Compara el 1 numero con el 2 y el 3 para saber si es el mas pequeo
        if (number1 < number2 && number1 < number3)
        {
            //Si el condicional anterior resulta correcto entonces el 1 es el mas pequeo
            smallest = number1;

            //Compara el 2 numero para saber si es < o = al 3
            if (number2 <= number3)
            {
                //Si es < o = al 3 entonces el 2 es el 2 numero en salir por consola y el 3 el 3 en salir
                middle = number2;
                largest = number3;

            }
            else
            {
                //Si el condicional anterior resulta falso entonces el 2 numero en salir por consola es el 3 y el 3 en salir es el 2
                middle = number3;
                largest = number2;

            }

        }
        //Compara el 2 numero con el 1 y el 3 para saber si es mas pequeo
        else if (number2 < number1 && number2 < number3)
        {
            //Si lo es entonces el 2 es el 1 en salir por consola
            smallest = number2;

            //Compara el 1 con el 3 para saber si el 1 es < o = que el 3
            if (number1 <= number3)
            {
                //Si el condicional anterior resulta correcto el 2 en salir por consola es el 1 y el 3 es el 3 en salir
                middle = number1;
                largest = number3;

            }
            else
            {
                //Si el condicional anteriore es falso el 2 en salir sera el 3 y el 3 sera el 1
                middle = number3;
                largest = number1;

            }

        }
        else
        {
            //Si el 3 es el mas pequeo
            smallest = number3;

            //Compara el 1 con el 2 para saber si el 1 es < o = al 2
            if (number1 <= number2)
            {
                //Si el condicional anterior resulta correcto el 2 numero en salir sera el 1 y el 3 sera el 2
                middle = number1;
                largest = number2;

            }
            else
            {
                //Si el condicional resulta falso el 2 en salir sera el 2 y el 3 en salir sera el 1
                middle = number2;
                largest = number1;

            }
        }

        // Muestra los numeros por consola
        Debug.Log("Los numeros asignados de menor a mayor son: " + smallest + "," + middle + "," + largest);
    }
}
