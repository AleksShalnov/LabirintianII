using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Cylinderway : MonoBehaviour
{
    public Transform goal;
    void Start()
    {
        UnityEngine.AI.NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }

}
