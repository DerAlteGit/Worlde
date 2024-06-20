using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StyleController : MonoBehaviour
{
    [SerializeField] public List<UIStyle> styles;
    [field:SerializeField]public UIStyle currentStyle { get; private set; }
    public MenuStyle currentGameStyle;
    private void Awake()
    {
        currentStyle = styles[PlayerPrefs.GetInt("Style")];
        
    }
    public bool ChangeStyle(int index)
    {
        if (index < styles.Count)
        {
            currentStyle = styles[index];
            PlayerPrefs.SetInt("Style", index);
            currentGameStyle.StyleChange();
            return true;
        }
        return false;
    }
}
