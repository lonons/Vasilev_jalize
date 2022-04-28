using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    [SerializeField] int damage = 6;
    [SerializeField] float force = 6;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.TryGetComponent(out Health health))
        {
            health.Hit(damage);
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 dir = collision.gameObject.transform.TransformDirection(Vector3.back * force);
            rb.AddForce(dir,ForceMode.Impulse);

            Destroy(gameObject);
        }
       
    }
}
