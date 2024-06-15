using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinPanel : Panel
{
    [HideInInspector]public string word;
    [HideInInspector]public int time;
    [HideInInspector]public int recordTime;

    [SerializeField] private Text wordText;
    [SerializeField] private Text timeText;
    [SerializeField] private Text recordText;
    public override void Init()
    {
        wordText.text = word;
        timeText.text = time.ToString()  + " сек.";
        recordText.text = recordTime.ToString() + " сек.";
    }
}
