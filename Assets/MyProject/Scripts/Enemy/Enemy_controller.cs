using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_controller : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] GameObject player;
     private Vector3 _direction;
    void Start()
    {
        
    }

    private void Update()
    {
        _direction = player.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, _direction, _speed* Time.deltaTime);
    }
}
