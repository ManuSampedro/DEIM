using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private void OnTriggerEnter(Collider infoAccess){

        if(infoAccess.CompareTag("Attack")){

            Destroy(gameObject);

        }

    }

}
