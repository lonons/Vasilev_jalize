using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Animator))]
public class New_enemy_controller : MonoBehaviour
{
    private NavMeshAgent agent;
    private LayerMask _mask;
    private GameObject player;
    private Animator animator;

    void Awake()
    {
        _mask = LayerMask.NameToLayer("Player");
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        animator = GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            RaycastHit hit;
            var startPos = transform.position;
            var dir = player.transform.position - startPos;
            var rayCast = Physics.Raycast(startPos, dir, out hit, Mathf.Infinity, _mask);
            if (rayCast)
            {
                if (hit.collider.gameObject.CompareTag("Player"))
                {
                    if (Vector3.Distance(transform.position, player.transform.position) <= 0.7f)
                    {
                        animator.SetBool("isWalk", false);
                        animator.SetBool("isAttack", true);
                    }
                    else
                    {
                        animator.SetBool("isAttack", false);
                        animator.SetBool("isWalk", true);
                        agent.SetDestination(player.transform.position);
                    }
                }
            }
            else animator.SetBool("isWalk", false);
            Debug.DrawRay(startPos, dir);
        }
    }

}
