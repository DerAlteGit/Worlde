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
    [SerializeField] private int rewardMoney;
    public override void Init()
    {
        wordText.text = word;
        timeText.text = time.ToString()  + " ���.";
        recordText.text = recordTime.ToString() + " ���.";
        PlayerPrefs.SetInt("PreviousMoney", PlayerPrefs.GetInt("Money"));
        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + rewardMoney);
    }
}
