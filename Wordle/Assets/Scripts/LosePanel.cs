using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LosePanel : Panel
{
    [HideInInspector] public string word;

    [SerializeField] private Text wordText;
    public override void Init()
    {
        wordText.text = word;
    }

    
}
