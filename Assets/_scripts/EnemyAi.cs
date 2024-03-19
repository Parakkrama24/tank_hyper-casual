using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyAi : MonoBehaviour
{
    public GameObject player;
    private NavMeshAgent navAgent;
    private float distance;
    [SerializeField] private float enemySpeed;
    [SerializeField] private float minDistznce;
    [SerializeField] private float maxDistznce;
    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        distance=Vector3.Distance(transform.position,player.transform.position);
     
        if (distance > minDistznce && distance < maxDistznce)
        {
            navAgent.SetDestination(player.transform.position);
        }
        else
        {
            navAgent.SetDestination(transform.position);
        }
       
    }
}
