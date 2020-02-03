using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 positionDirection;
    public float speed = 5f;
    public float gravity = -3f;
    public float jumpForce = 50f;

    void Start()
    {
        
    }

    void Update()
    {
        positionDirection.x = Input.GetAxis("Horizontal") * speed;
        if (Input.GetButtonDown("Jump"))
        {
            positionDirection.y = jumpForce;
        }
        positionDirection.y += gravity;
        controller.Move(positionDirection * Time.deltaTime);

       // positionDirection.z = Input.GetAxis("Horizontal") * speed;

    }
    
}
