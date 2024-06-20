using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoney : MonoBehaviour
{
    public static event Action onChange;
    [SerializeField]private List<Text> moneyTexts;
    //[SerializeField] private Text animationText;
    //public Animator animator;
    [field:SerializeField]public int money { get; private set; }
    private void Start()
    {
        Init();
    }
    public void Init()
    {
        money = PlayerPrefs.GetInt("Money");
        
        
            UpdateMoney();
        
    }

  /* public void AddMoney(int money)
    {
        PlayerMoney.money = money;
        onChange?.Invoke();
    }*/
    public void UpdateMoney()
    {
        foreach(var moneyText in moneyTexts)moneyText.text = money.ToString();
        money = PlayerPrefs.GetInt("Money");
        
    }
    public bool SpendMoney(int money)
    {
        UpdateMoney();
        if(this.money >= money)
        {
            this.money -= money;
            UpdateMoney();
            return true;
        }
        UpdateMoney();
        return false;
    }
}
