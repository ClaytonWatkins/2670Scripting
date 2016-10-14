using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    Vector3 moveDirection;
    public float speed = 10;
    public float gravity = 3;
    public float jumpSpeed = 30;
    CharacterController cc;

    public void StopMoving()
    {
        MoveUsingArrowKeys.MoveOnArrows -= Move;
        MoveUsingArrowKeys.RotateOnArrows -= Rotate;
    }

    void StopScript ()
    {
        MoveUsingArrowKeys.MoveOnArrows -= Move;
        MoveUsingArrowKeys.RotateOnArrows -= Rotate;
    }

    void StartGameHandler ()
    {
        MoveUsingArrowKeys.MoveOnArrows += Move;
        GameControl.StartGame -= StartGameHandler;
    }

    void Start()
    {
        EndGame.GameOver += StopScript;
        cc = GetComponent<CharacterController>();
        GameControl.StartGame += StartGameHandler;
       // MoveUsingButtons.Forward += Move;
        //MoveUsingArrowKeys.RotateOnArrows += Rotate;
        //MoveUsingButtons.Rotate += Rotate;
    }

    void Rotate(float _rotateInY)
    {
        transform.Rotate(0, _rotateInY, 0);
    }


    void Move(float _moveInZ)
    {
        moveDirection.y -= gravity;
        moveDirection.x = _moveInZ;
        moveDirection = transform.TransformDirection(moveDirection * speed * Time.deltaTime);
        cc.Move(moveDirection);
    }
}