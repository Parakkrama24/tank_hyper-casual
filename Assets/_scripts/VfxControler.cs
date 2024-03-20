using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VfxControler : MonoBehaviour
{
   
    void Start()
    {
        Invoke("destoyObject", 2.5f);
    }

    private void destoyObject()
    {
        Destroy(this.gameObject);
    }

}
