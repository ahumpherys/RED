using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public string LevelOne;

    public void NewGame()
    {
        SceneManager.LoadScene("LavaGame");
    }
}
