using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month : MonoBehaviour
{
    //Zona de Variables Globales

    public int month;

    void Start()
    {
        //Llamo al metodo
        Months();

    }

    //Metodo 
    private void Months()
    {
        //El condicional "Switch" nos permite realizar varias acciones dependiendo del valor que tenga la caso
        switch (month)
        {
            case 1:
                Debug.Log("El primer mes es Enero");
                break;
            case 2: 
                Debug.Log("El segundo mes es Febrero");
                break;
            case 3: 
                Debug.Log("El tercer mes es Marzo");
                break;
            case 4: 
                Debug.Log("El cuarto mes es Abril");
                break;
            case 5: 
                Debug.Log("El quinto mes es Mayo");
                break;
            case 6: 
                Debug.Log("El sexto mes es Junio");
                break;
            case 7: 
                Debug.Log("El septimo mes es Julio");
                break;
            case 8: 
                Debug.Log("El octavo mes es Agosto");
                break;
            case 9: 
                Debug.Log("El noveno mes es Septiembre");
                break;
            case 10: 
                Debug.Log("El decimo mes es Octubre");
                break;
            case 11: 
                Debug.Log("El undecimo mes es Noviembre");
                break;
            case 12: 
                Debug.Log("El duodecimo mes es Diciembre");
                break;
            default:
                Debug.Log("Este numero no corresponde a ningun mes");
                break;
        }
    }
}