using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class hedefeGidis : MonoBehaviour
{
    public GameObject varisYeri;
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

   
    void Update()
    {
        agent.SetDestination(varisYeri.transform.position);
    }
}
