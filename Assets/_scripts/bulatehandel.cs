using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulatehandel : MonoBehaviour
{
    [SerializeField] private float launchSpeed = 75.0f;
    [SerializeField] private GameObject BulatePreFab;
    [SerializeField] private GameObject ShootFx;
    private bool isShoot;
    void Start()
    {
        
    }

    public void  Shoot()
    {
        isShoot = true;
    }
   
    void Update()
    {
        //input
        if(isShoot)
        {
            spwanObject();
            isShoot=false;
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
        GameObject fx = Instantiate(ShootFx, spawmPotitonn, spawnRotation);
        StartCoroutine(destroyFx(fx));

        bulateNew.transform.rotation = GetComponentInParent<Transform>().rotation;
        Rigidbody rb = bulateNew.GetComponent<Rigidbody>();
        //add velocity 
        rb.velocity = velocity;
    }

    private IEnumerator destroyFx( GameObject fxObj)
    {
        yield return new WaitForSeconds(2f);
        Destroy(fxObj );
    }
}
