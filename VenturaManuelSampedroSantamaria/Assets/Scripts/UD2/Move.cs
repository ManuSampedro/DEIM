using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    //Zona de variables globales

    [SerializeField][Header("Move")]
    private float _speed = 2.5f,
                  _turnSpeed = 90.0f;

    [SerializeField][Header("Coordenadas")]
    private float _horizontal,
                  _vertical;

    [Header("Jump")]
    public float JumpForce = 150.0f;
    
    [SerializeField][Header("RayCast")]
    private float _RayLength = 0.1f;

    private Ray _ray;
    private RaycastHit _hit;
    private bool _isGrounded;
    private bool _canPlayerJump;
    
    [SerializeField][Header("ShotFlower")]
    public GameObject Flower;
    public Transform FlowerSpawn;
    public float thrustY = 200.0f,
                 thrustZ = 100.0f,
                 timeFlower = 2.0f;

    [SerializeField][Header("RigidBody")]
    private Rigidbody _rb;

    [SerializeField][Header("Animator")]
    private Animator anim;

    private void Awake()
    {

        _rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        

    }
    
    void Update()
    {

        Turn();
        Movemen();
        InputPlayer();
        CanJump();
        Walk();
        AnimJump();
        Run();
        
        if(Input.GetMouseButtonDown(0)){
        
        CreateFlower();
        Attack();
        
        }
    }

    private void FixedUpdate()
    {

        LaunchRaycast();
        
        if(_canPlayerJump)
        {

            _canPlayerJump = false;
            Jump();

        }

    }

    private void LaunchRaycast()
    {

        _ray.origin = transform.position;
        _ray.direction = -transform.up;

        if(Physics.Raycast(_ray, out _hit, _RayLength)){

            _isGrounded = true;

        }
        else
        {
            
            _isGrounded = false;

        }
        
        Debug.DrawRay(_ray.origin, _ray.direction * _RayLength, Color.red);

    }

    private void InputPlayer()
    {

        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
        
    }

    private void Movemen()
    {

        transform.Translate(Vector3.forward * _speed * _vertical * Time.deltaTime);

    }

    private void Turn()
    {

        transform.Rotate(Vector3.up * _turnSpeed * _horizontal * Time.deltaTime);

    }

    private void CanJump()
    {

        if(Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {

            _canPlayerJump = true;

        }

    }

    private void Jump()
    {

        _rb.AddForce(Vector3.up * JumpForce);

    }
    
    private void CreateFlower()
    {

        GameObject cloneFlower = Instantiate(Flower, FlowerSpawn.position, FlowerSpawn.rotation);

        Rigidbody rbFlower = cloneFlower.GetComponent<Rigidbody>();
        rbFlower.AddForce(Vector3.up * thrustY);
        rbFlower.AddForce(transform.forward * thrustZ);
        
        Destroy(cloneFlower, timeFlower);

    }  

    private void Attack()
    {

        anim.SetTrigger("Attack");

    }

    private void Walk()
    {

        if(_vertical !=0)
        {

            anim.SetBool("Walk", true);

        }
        else
        {

            anim.SetBool("Walk", false);

        }

    }

    private void AnimJump()
    {

        if(Input.GetKeyDown(KeyCode.Space) && _isGrounded){

            anim.SetBool("Jump", true);

        }
        else
        {

            anim.SetBool("Jump", false);

        }

    }

    private void Run()
    {

        if(Input.GetKey(KeyCode.LeftShift)){

            _speed = 5.0f;
            anim.SetBool("Run", true);

        }
        else
        {
            _speed = 2.5f;
            anim.SetBool("Run", false);

        }

    }

}
