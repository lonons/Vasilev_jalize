using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace jalize
{
    public class Enemy_controller : MonoBehaviour
    {

        private NavMeshAgent agent;
        private Transform player;

        private void Awake()
        {
            agent = GetComponent<NavMeshAgent>();
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }

        private void Update()
        {
            agent.SetDestination(player.transform.position);
        }

    }

}

