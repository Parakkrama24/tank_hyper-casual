using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulatehandel : MonoBehaviour
{
    [SerializeField] private float launchSpeed = 75.0f;
    [SerializeField] private GameObject BulatePreFab;
    void Start()
    {
        
    }

   
    void Update()
    {
        //input
        if(Input.GetKeyUp(KeyCode.Space))
        {
            spwanObject();
        }
    }

    void spwanObject()
    {
        //set spawan Location and rotation
        Vector3 spawmPotitonn = transform.position;
        Quaternion spawnRotation = Quaternion.identity;
        //set velocity 
        Vector3 localxDirection = transform.TransformDirection(Vector3.forward);
        Vector3 velocity = localxDirection* launchSpeed;

        //instantialte
        GameObject bulateNew = Instantiate(BulatePreFab, spawmPotitonn, spawnRotation);
        bulateNew.transform.rotation = GetComponentInParent<Transform>().rotation;
        Rigidbody rb = bulateNew.GetComponent<Rigidbody>();
        //add velocity 
        rb.velocity = velocity;
    }
}
