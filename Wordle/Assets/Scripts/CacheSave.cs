using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public static class CacheSave
{
    public static void SaveCurrentWord(string word)
    {
        PlayerPrefs.SetString("CurrentWord", word);
    }
    public static void SaveChars(string[] symbols)
    {
        for (int i = 0; i < symbols.Length; i++)
        {
            PlayerPrefs.SetString("Char" + i.ToString(), symbols[i]);
            

        }
    }
    public static void SaveChainState(bool isUnlocked)
    {
        PlayerPrefs.SetInt("IsUnlock", Convert.ToInt32(isUnlocked));
    }
    public static bool GetChainState()
    {
        bool state = Convert.ToBoolean(PlayerPrefs.GetInt("IsUnlock"));
        return state;
    }
    public static string[] GetSymbols()
    {
        List<string> symbols = new List<string>();  
        for(int i = 0; i < 25; i++)
        {
           string symbol = PlayerPrefs.GetString("Char" +  i.ToString());
            if(symbol != null || symbol != "")
            {
                symbols.Add(symbol);
            }
            
        }
        return symbols.ToArray();
    }
    public static string GetCurrentWord()
    {
        return PlayerPrefs.GetString("CurrentWord");
    }
}
