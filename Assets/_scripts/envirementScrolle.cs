using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class envirementScrolle : MonoBehaviour
{
   [SerializeField] private float scrolSpeed = -10f;
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Translate(Vector3.forward * scrolSpeed * Time.deltaTime);
        if (transform.position.z <= -120)
        {
            transform.position= new Vector3(transform.position.x,transform.position.y, 100f);
        }
    }
}
