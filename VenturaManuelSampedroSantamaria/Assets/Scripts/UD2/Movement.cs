using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField]
    private float _speed = 5.0f, 
                  _turn = 180.0f;
    
    void Update()
    {
        
        if(Input.GetKey(KeyCode.W)){

            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        
        }
        
        if(Input.GetKey(KeyCode.S)){

            transform.Translate(Vector3.back * _speed * Time.deltaTime);
        
        }

        if(Input.GetKey(KeyCode.D)){

            transform.Rotate(Vector3.up * _turn * Time.deltaTime);
        
        }

        if(Input.GetKey(KeyCode.A)){

            transform.Rotate(Vector3.down * _turn * Time.deltaTime);
        
        }
        
    }
}
