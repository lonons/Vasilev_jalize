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
        private LayerMask _mask ;


        private void Awake()
        {
            _mask = LayerMask.NameToLayer("Player");
            agent = GetComponent<NavMeshAgent>();
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                RaycastHit hit;
                var startPos = transform.position;
                var dir = player.position - startPos;
                var rayCast = Physics.Raycast(startPos, dir, out hit, Mathf.Infinity, _mask);
                if (rayCast)
                {
                    if (hit.collider.gameObject.CompareTag("Player"))
                    {
                        agent.SetDestination(player.transform.position);
                    }
                }
                Debug.DrawRay(startPos, dir);
            }
        }

    }

}

