using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW2 : MonoBehaviour
//attempting to remake character controller for practice HW
{
    public CharacterController Player1;
    public Vector3 Direction;
    public float speed = 10f;
    public float gravity = -2f;
    public float jumping = 50f;
    void Start()
    {
    }
    void Update()
    {
        Direction.y += gravity;
        Direction.x = Input.GetAxis("Horizontal") * speed;
        if (Input.GetButtonDown("Jump"))
        {
            Direction.y = jumping;
        }
        Player1.Move(Direction * Time.deltaTime);
    }
}