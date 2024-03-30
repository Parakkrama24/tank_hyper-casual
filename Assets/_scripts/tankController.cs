using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class tankController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private float rotateSpeed = 120.0f;
    [SerializeField] GameObject[] LeftWeels;
    [SerializeField] GameObject[] rightWeels;
    [SerializeField] private float wheelRotationSpeed = 200f;
    private Rigidbody rb;
    private float moveinput;
    private float wheelRotateInput = 1;//only hyper cadhuval game 
    private float rotationInputs;
    [HideInInspector] public bool isDead;

    private enum state{

        dead,
        live

    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        moveinput = 0;// Input.GetAxis("Vertical");

        rotationInputs = Input.GetAxis("Horizontal");
        RotateWheels(moveinput, rotationInputs);
    }
    private void FixedUpdate()
    {
        MoveTankObj(moveinput);
       // RotateTank(rotationInputs);
    }
    void MoveTankObj(float input)
    {
        Vector3 moveDirection = transform.forward *input* moveSpeed*Time.fixedDeltaTime;
        rb.MovePosition(rb.position+moveDirection);
    }
    void RotateTank(float input)
    {
        float rotation = input* rotateSpeed*Time.fixedDeltaTime;
        Debug.Log(rotation);
        rotation= Mathf.Clamp(rotation,-45,45);
        Quaternion turnrotation = Quaternion.Euler(0f, rotation, 0f);

        rb.MoveRotation(rb.rotation * turnrotation);

    }
    void RotateWheels(float MoveInput,float rotationInput)
    {
        float wheelRotation = wheelRotateInput * wheelRotationSpeed*Time.fixedDeltaTime;

        //move leftweels

        foreach(GameObject wheel in LeftWeels)
        {
            if(wheel != null)
            {
                wheel.transform.Rotate(wheelRotation - rotationInput * wheelRotationSpeed * Time.deltaTime,0.0f,0.0f);
            }
        }
        //move rightweels
        foreach(GameObject wheel in rightWeels)
        {
            if(wheel != null)
            {
                wheel.transform.Rotate(wheelRotation + rotationInput * wheelRotationSpeed * Time.deltaTime,0.0f,0.0f);
            }
        }
    }

    private void changeState(string state)
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            isDead= true;
        }
    }
}
