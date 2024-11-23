using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eggs : MonoBehaviour
{

    //Zona de variables globales
    public GameObject Egg;
    public Transform Spawn;
    public float timeEgg = 2.0f;

    void Update()
    {

        CreateEgg();
        
    }

    private void CreateEgg(){

        if(Input.GetMouseButtonDown(0)){

        GameObject cloneEgg = Instantiate (Egg,Spawn.position, Spawn.rotation);

        Destroy (cloneEgg,timeEgg);
        
        }

    }

}
