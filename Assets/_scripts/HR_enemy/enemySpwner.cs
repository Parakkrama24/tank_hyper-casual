using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpwner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemyTanks;
    [SerializeField] private Transform[] tanksSpownerpotiton;
    

    void Start()
    {
        InvokeRepeating("spawn", 2f, 2f); 
    }

   
    void Update()
    {
        
    }

    private void spawn()
    {
        Quaternion spwanRotation =  Quaternion.Euler(0f, 180f, 0f);
        int randomObjectNumber= UnityEngine.Random.Range(0,enemyTanks.Length);
        int randomTransform = UnityEngine.Random.Range(0, tanksSpownerpotiton.Length);
        Instantiate(enemyTanks[randomObjectNumber], tanksSpownerpotiton[randomTransform].position, spwanRotation);
    }
}
