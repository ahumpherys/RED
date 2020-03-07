using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public GameObject[] ArrayOBJ;
    int[] LongArray = new int[5];
    private int[] ShortArray = {3, 6, 9, 12, 15};

    void Start()
    {
        LongArray[0] = 10;
        LongArray[1] = 15;
        LongArray[2] = 20;
        LongArray[3] = 25;

        ShortArray[4] = 18;

       // players = GameObject.FindGameObjectWithTag("Player");
       //for (int i = 0; i < players.Length; i++)
      //  {
     //       Debug.Log("Player Number"+i+"is named"+players[i].name);
    //    }
    
        // Code doesn't work despite giving objects "player" tag.
        //"players" is in red and needs to be defined.
        
        //code is from following along arrays video in canvas

    }

}