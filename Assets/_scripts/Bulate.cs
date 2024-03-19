using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulate : MonoBehaviour
{
   
    void Start()
    {
        Invoke("destroybualate", 2f);
    }

   
    void Update()
    {
        
    }

    private void destroybualate()
    {
        Destroy(gameObject);
    }
}
