using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoney : MonoBehaviour
{
    public static event Action onChange;
    [SerializeField]private Text moneyText;
    [field:SerializeField]public int money { get; private set; }
    private void Start()
    {
        Init();
    }
    public void Init()
    {
        onChange += () =>
        {
            PlayerPrefs.SetInt("Money", money);
            moneyText.text = money.ToString();
        };
    }
  /* public void AddMoney(int money)
    {
        PlayerMoney.money = money;
        onChange?.Invoke();
    }*/
    public bool SpendMoney(int money)
    {
        if(this.money >= money)
        {
            this.money -= money;
            onChange?.Invoke();
            return true;
        }
        return false;
    }
}
