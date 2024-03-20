using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    [SerializeField] private float speed = 100f;
    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector3.forward * speed*Time.deltaTime);
    }
}
