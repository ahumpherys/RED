using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    public KeyCode key1 = KeyCode.LeftArrow, key2 = KeyCode.RightArrow;
    public float direction = 0, direction2 = 180;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            transform.rotation = Quaternion.Euler(x: 0, y: direction, z: 0);
        }

        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            transform.rotation = Quaternion.Euler(x: 0, y: direction2, z: 0);
        }
    }
}
//code is from following along in the class