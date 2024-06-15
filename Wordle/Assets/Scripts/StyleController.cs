using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StyleController : MonoBehaviour
{
    public UIStyle currentStyle;
    public event Action onStyleChange;

    public void ChangeStyle(UIStyle style)
    {
        currentStyle = style;
        onStyleChange?.Invoke();
    }
}
