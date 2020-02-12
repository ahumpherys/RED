using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW1 : MonoBehaviour
{
    public int Apples = 20;
    public int Oranges = 20;
    public int Pears = 9;
    public string FourtyNine = "There are 49 fruits";
    public string NoNoNo = "There is not 49 fruit. How dare you!";

    void Start()
    {
        if (Apples + Oranges + Pears == 49)
        {
            print(FourtyNine);
        }

        if (Apples + Oranges + Pears != 49)
        {
            print(NoNoNo);
        }
    }
}
//Practice going over what we learned in class