using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class StringData : ScriptableObject
{
 public string value;

 public void ChangeValue(string number)
 {
  value += number;
 }
}
