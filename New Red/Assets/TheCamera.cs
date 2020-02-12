using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform playerPosition;

    public Vector3 offSet;
    // Update is called once per frame
    void Update()
    {
        transform.position = playerPosition.position + offSet;
    }
}
