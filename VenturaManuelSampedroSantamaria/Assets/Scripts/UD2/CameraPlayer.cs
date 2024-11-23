using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    //Zona de Variables Globales

    public Transform Target;
    private float _smoothing;
    private Vector3 _offset;


    // Start is called before the first frame update
    void Start()
    {

        _offset = transform.position - Target.position;
        _smoothing = 0.1f;
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 camPosition = Target.position + _offset;
        transform.position = Vector3.Lerp(transform.position, camPosition, _smoothing * Time.deltaTime);
        
    }
}
