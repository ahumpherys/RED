using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageBehav : MonoBehaviour
{
    private Image ImageObj;
    
    private void Start()
    {
        ImageObj = GetComponent<Image>();
    }
    
    void Update()
    {
        
    }
}
//Code from following along in class