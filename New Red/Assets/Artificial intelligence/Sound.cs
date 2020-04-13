using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource sound;
    public GameObject ammo;
    
    void Update()
    {
        if (Input.GetButtonDown("fire1"))
        {
            Shot();
        }
    }

    void Shot()
    {
        Instantiate(ammo, transform.position, transform.rotation);
        sound.Play();
    }
}
//code from following along in class