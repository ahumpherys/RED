using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class TextBehavior : MonoBehaviour
{
    private Text TextObj;
    public IntData dataObj;
    private void Start()
    {
        TextObj = GetComponent<Text>();
    }
    
    void Update()
    {
        TextObj.text = dataObj.value.ToString();
    }
}
//Code from following along in class