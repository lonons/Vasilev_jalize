using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_open_door : MonoBehaviour
{
    [SerializeField] Animator anim;
   
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.name == "Player") 
        {       
            anim.Play("open_door");
            Destroy(this.gameObject);
        }

    }
}
