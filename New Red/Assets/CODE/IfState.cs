using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfState : MonoBehaviour
{
    //practicing IF statements using an hourglass as an example and following allong if statement video on canvas.
    float SandStart = 100.0f;
    float HalfWayMarker = 50.0f;
    float OutOfTime = 0.0f;
    public float SandFallTime = -5f;
    void Update()
    {

        if (Input.GetButtonDown(KeyCode.Space.ToString()))
            //Code isn't working like in video, had to add ".ToString()" Not sure what it does, Will fix later.
            //Also need to set up Input Button Space
            SandAmount();
        SandStart -= Time.deltaTime * SandFallTime;
    }

    void SandAmount()
    {
        if (SandStart > HalfWayMarker)
        {
            print("Plenty of Time left.");
        }
        else if (SandStart < OutOfTime)
        {
            print("You have run out of time.");
        }
        else
        {
            print("Your time is running out");
        }
    }
}
