using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour
{
    public Transform playerPosition;
    public Vector3 offSet;
    void Update()
    {
        transform.position = playerPosition.position + offSet;
    }
}
