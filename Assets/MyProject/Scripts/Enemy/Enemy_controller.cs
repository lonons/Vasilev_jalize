using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace jalize
{
    public class Enemy_controller : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] Transform player;
        private Vector3 _direction;


        private void OnTriggerStay(Collider coll)
        {
            if (coll.name == "Player")
            {
                _direction = player.position;
                transform.position = Vector3.MoveTowards(transform.position, _direction, _speed * Time.deltaTime);
                Vector3 targetDir = player.position - transform.position;
                Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, 10 * Time.deltaTime, 0.0f);
                transform.rotation = Quaternion.LookRotation(newDir);
            }
        }
    }

}

