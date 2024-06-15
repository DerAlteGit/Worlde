using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsLight : MonoBehaviour
{

    [SerializeField]private List<CharButton> keyBoards = new List<CharButton>();
    public void ChangeLight(List<CharButton> wordChars, string answerWord)
    {
        for(int i = 0; i < wordChars.Count; i++)
        {
            if (wordChars[i].Symbol == answerWord[i].ToString())
            {
                wordChars[i].ChangeColor(CharState.Green);
                foreach (var item in keyBoards)
                {
                    if (item.Symbol[0] == answerWord[i])
                    {
                        item.ChangeColor(CharState.Green);
                    }
                }
            }
            else if (answerWord.Contains(wordChars[i].Symbol[0]))
            {
                wordChars[i].ChangeColor(CharState.Yellow);
                foreach (var item in keyBoards)
                {
                    if (item.Symbol == wordChars[i].Symbol.ToString())
                    {
                        item.ChangeColor(CharState.Yellow);
                    }
                }
            }
            else
            {
                wordChars[i].ChangeColor(CharState.White);
                foreach (var item in keyBoards)
                {
                    if (item.Symbol == wordChars[i].Symbol.ToString())
                    {
                        item.ChangeColor(CharState.White);
                    }
                }
            }
        }
        
    }
}
