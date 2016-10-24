using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    Vector3 moveDirection;
    public float speed = 10;
    public float gravity = 1;
    public float jumpSpeed = 30;
    CharacterController cc;

    void Start()
    {
        cc = GetComponent<CharacterController>();
        MoveUsingArrowKeys.MoveOnArrows += Move;
        MoveUsingArrowKeys.RotateOnArrows += Rotate;
    }

    void Rotate(float _rotateInY)
    {
        transform.Rotate(0, _rotateInY, 0);
    }

    void Move(float _moveInZ)
    {
        if (cc.isGrounded) {
            if (Input.GetKey(KeyCode.Space))
            {
                moveDirection.y = jumpSpeed * Time.deltaTime;
            }

            moveDirection.y -= gravity * Time.deltaTime;

            moveDirection.x = _moveInZ * speed * Time.deltaTime;
            moveDirection = transform.TransformDirection(moveDirection*Time.deltaTime);
            cc.Move(moveDirection);
        }
    }
}