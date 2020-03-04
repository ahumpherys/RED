using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
    public Vector3 value;

    public void ChangePosition(Transform transformOBJ)
    {
        transformOBJ.position = value;
    }

    public void ChangeValueFromTransform(Transform transformOBJ)
    {
        value = transformOBJ.position;
    }
    
    public void ChangeVector3Data(Vector3Data vector3DataOBJ)
    {
        vector3DataOBJ.value = value;
    }
    
    
}