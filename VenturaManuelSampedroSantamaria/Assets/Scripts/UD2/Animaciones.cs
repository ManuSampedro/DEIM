using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaciones : MonoBehaviour
{
    //Zona de variables Globales

    [SerializeField]
    private Animator anim;

    private void Awake()
    {

    anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {


        if(Input.GetKeyDown(KeyCode.Space)){

            Jump();

        }
    }


    private void Jump()
    {

        anim.SetBool("Jump", true);

    }


}
