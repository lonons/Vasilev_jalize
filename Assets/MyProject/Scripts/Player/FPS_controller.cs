using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FPS_controller : MonoBehaviour
{
    [SerializeField] private float _speed; 

    [SerializeField] private Vector3 _direction;

    private string horizontal = "Horizontal";
    private string vertical = "Vertical";
    private string jump = "Jump";

    void Update()
    {
        _direction.x = Input.GetAxis(horizontal);
        _direction.z = Input.GetAxis(vertical);
        _direction.y = Input.GetAxis(jump);
    }
    void FixedUpdate()
    {
        var speed = _direction * _speed * Time.deltaTime;
        transform.Translate(speed);
    }

}
