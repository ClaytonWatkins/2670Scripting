using UnityEngine;
using System.Collections;

public class KeyboardControls : MonoBehaviour
{

    private Rigidbody rb;
    public float Speed = 5;
    public float RunSpeed = 7;
    public float JumpSpeed = 250;
    public float RotateSpeed = 2;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, JumpSpeed, 0);
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            rb.velocity = transform.TransformDirection(new Vector3(-Speed, rb.velocity.y, 0));

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
            rb.velocity = transform.TransformDirection(new Vector3(-RunSpeed, rb.velocity.y, 0));

        if (Input.GetKey(KeyCode.S))
            rb.velocity = transform.TransformDirection(new Vector3(Speed, rb.velocity.y, 0));

        if (Input.GetKey(KeyCode.A))
            rb.transform.Rotate(0, -RotateSpeed, 0);

        if (Input.GetKey(KeyCode.D))
            rb.transform.Rotate(0, RotateSpeed, 0);
    }
}