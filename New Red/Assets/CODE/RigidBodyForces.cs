using System;
using UnityEngine;

public class RigidBodyForces : MonoBehaviour
{
   public Rigidbody rigidBodyOBJ;
   public float force = 100;
   private Vector3 forceVector;
      
   private void OnCollisionEnter(Collision other)
   {
      forceVector.y = force;
      rigidBodyOBJ.AddForce(forceVector);
      //print("I hit something.");
   }
}
//code from following along in class