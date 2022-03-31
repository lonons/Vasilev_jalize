using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FPS_controller : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _direction;


    private string horizontal = "Horizontal";
    private string vertical = "Vertical";
    private string jump = "Jump";

    public float mouseSensitivityX = 1.0f;
    public float mouseSensitivityY = 1.0f;

    Transform cameraT;
    float verticalLookRotation;

    private void Start()
    {
        UnityEngine.Cursor.visible = false;
        cameraT = Camera.main.transform;
    }

    void Update()
    {
        _direction.x = Input.GetAxis(horizontal);
        _direction.z = Input.GetAxis(vertical);
        _direction.y = Input.GetAxis(jump);
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * mouseSensitivityX);
        verticalLookRotation += Input.GetAxis("Mouse Y") * mouseSensitivityY;
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -60, 60);
        cameraT.localEulerAngles = Vector3.left * verticalLookRotation;
    }
    void FixedUpdate()
    {
        var speed = _direction * _speed * Time.deltaTime;
        transform.Translate(speed);
    }

}
