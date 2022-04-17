using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace jalize
{
    [RequireComponent(typeof(NavMeshAgent))]
    [RequireComponent(typeof(Animator))]
    public class Enemy_controller : MonoBehaviour
    {
        private NavMeshAgent agent;
        private Transform player;
        private LayerMask _mask ;
        private Animator animator;



        private void Awake()
        {
            animator = GetComponent<Animator>();
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
                        if (Vector3.Distance(transform.position, player.position) <= 0.6f)
                        {
                            animator.SetBool("isAttack", true);
                        }
                        else
                        {
                            agent.SetDestination(player.transform.position);
                        }
                        
                    }
                }
                Debug.DrawRay(startPos, dir);
            }
        }

    }

}

