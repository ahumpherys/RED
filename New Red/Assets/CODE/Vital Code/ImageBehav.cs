using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageBehav : MonoBehaviour
{
    private Image ImageObj;
    public FloatData dataObj;
    private void Start()
    {
        ImageObj = GetComponent<Image>();
    }
    
    void Update()
    {
        ImageObj.fillAmount = dataObj.value;
    }
}
//Code from following along in class