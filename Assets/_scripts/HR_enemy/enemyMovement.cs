using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    [SerializeField] private float speed = 100f;
    public EnemyData enemyData;
    private float enemyHelth;
    void Start()
    {
        enemyHelth = enemyData.health;
    }


    void Update()
    {
        transform.Translate(Vector3.forward * speed*Time.deltaTime);
        if(enemyHelth <= 0)
        {
            Destroy(gameObject);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bulate"))
        {
            Debug.Log("bulate");
            enemyHelth -= 25;
        }
        else if (collision.gameObject.CompareTag("backWall"))
        {
            Debug.Log("backwall");
            Destroy(gameObject);
        }
    }
}
