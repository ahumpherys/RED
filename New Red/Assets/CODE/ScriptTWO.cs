using UnityEngine;

public class ScriptTWO : MonoBehaviour
{
    public int a = 10;
    public int b = 4;
    public int c = 14;
    public string password = "123456";
    public bool canRun = true;
    public int jumpCount = 2;

    void Start()
    {
        if (a + b == c)
        {
          print(("That is true."));
        }

        if (password == "123456")
        {
          print("That is the correct password");
        }

        if (canRun)
        {
          print("You can run.");
        }
        //if (controller.isGrounded);
       // positionDirection.y = 0;
        
    }
}    