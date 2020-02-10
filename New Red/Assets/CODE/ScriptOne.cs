using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScriptOne : MonoBehaviour
{
    public UnityEvent MouseDownEvent, OnMouseUpEvent, OnMouseEnterEvent, OnMouseDragEvent, OnMouseExitEvent;

    public void OnMouseExit()
    {
        OnMouseExitEvent.Invoke();
    }

    public void OnMouseUp()
    {
        OnMouseUpEvent.Invoke();
    }

    public void OnMouseEnter()
    {
        OnMouseEnterEvent.Invoke();
    }

    public void OnMouseDrag()
    {
        OnMouseDragEvent.Invoke();
    }

    private void OnMouseDown()
    {
        MouseDownEvent.Invoke();
    }
}
