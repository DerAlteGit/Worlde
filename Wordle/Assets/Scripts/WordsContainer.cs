using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class WordsContainer : MonoBehaviour
{
    [SerializeField]private TextAsset _textAsset;
    public string Word { get;private set; }
    public List<string> ParseWords()
    {
        List<string> words = new List<string>();
        for(int i = 0; i < _textAsset.text.Split("\n").Length; i++)
        {
            words.Add(_textAsset.text.Split("\n")[i]);
        }
        return words;
    }
    public string GetRandomWord()
    {
        List<string> words = ParseWords();
        int index = new System.Random().Next(0, words.Count);
        Word = words[index].ToUpper();
        return words[index].ToUpper();
    }
}
