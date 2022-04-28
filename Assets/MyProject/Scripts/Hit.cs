using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    [SerializeField] int damage = 4;
    [SerializeField] float distance_damage = 0.7f;
    void Hit_damage()
    {
        RaycastHit raycast;
        Vector3 dir = transform.TransformDirection(Vector3.forward);
        Physics.Raycast(transform.position, dir,out raycast,distance_damage);
        if (raycast.collider.gameObject.TryGetComponent(out Health health))
        {
            health.Hit(damage);
        }
    }
}
