using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FPS_controller : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float runSpeed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float jumpSpeed;

    private Vector3 _direction;
    private Vector3 _directionJump;

    private Rigidbody rb;

    private string horizontal = "Horizontal";
    private string vertical = "Vertical";
    private string run = "Run";
    private string jump = "Jump";

    private bool isRunning;
    private bool isGround;

    public float mouseSensitivityX = 1.0f;
    public float mouseSensitivityY = 1.0f;

    Transform cameraT;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        UnityEngine.Cursor.visible = false;
        cameraT = Camera.main.transform;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ground") isGround = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "ground") isGround = false;
    }

    void Update()
    {
        _direction.x = Input.GetAxis(horizontal);
        _direction.z = Input.GetAxis(vertical);
        _directionJump.y = Input.GetAxis(jump);
        isRunning = Input.GetKey(KeyCode.LeftShift);
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * mouseSensitivityX);

    }
    void FixedUpdate()
    {
        Vector3  dir = rb.transform.TransformDirection(_direction * (isRunning ? runSpeed : _speed));
        Vector3 dirJump = rb.transform.TransformDirection(_directionJump * jumpSpeed);
        rb.AddForce(dir, ForceMode.Force);
        if (isGround) rb.AddForce(dirJump, ForceMode.Impulse);
        
    }
}
