using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulate : MonoBehaviour
{
    [SerializeField] private GameObject exlptionVfx;
    void Start()
    {
        Invoke("destroybualate", 2f);
    }

   
    void Update()
    {
        
    }

    private void destroybualate()
    {
        Instantiate(exlptionVfx, transform.position, Quaternion.identity);
        Destroy(gameObject);

    }
}
