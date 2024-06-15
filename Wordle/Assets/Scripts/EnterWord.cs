using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterWord : MonoBehaviour
{
    [SerializeField]private List<CharButton> images = new List<CharButton>();
    [SerializeField] private int currentRow;
    [SerializeField] private int maxRow;
    [SerializeField] private string word;
    [SerializeField] private ButtonsLight light;
    [SerializeField] private GameOver gameContoller;
    
    private void Start()
    {
        NewWord();
        FindObjectOfType<UnlockLine>().onUnlock += () => maxRow = 5;
        FindObjectOfType<UnlockLine>().onLock += () => maxRow = 4;
        
    }
    public void NewWord()
    {
        var parser = FindObjectOfType<WordsContainer>();
        word = parser.GetRandomWord();
    }
    public void Erase()
    {
        int index = FindNextIndex();
        if(index > 0  && index != currentRow * 5 )
        {
            images[index - 1].ChangeSymbol("");
        }
    }
    public int FindNextIndex()
    {
        for(int i = 0; i < images.Count; i++)
        {
            if (images[i].Symbol == null || images[i].Symbol == "")
            {
                return i;
            }
        }
        return -1;
    }
    public List<CharButton> GetWordButtons()
    {
        List<CharButton> result = new List<CharButton>();
        for (int i = 5 * currentRow; i < 5 * currentRow + 5; i++)
        {
            result.Add(images[i]);
        }
        return result;
    }
    public string GetCurrentWord()
    {
        string currentWord = "";
        for (int i = 5 * currentRow; i < 5 * currentRow + 5; i++)
        {
            currentWord += images[i].Symbol;
        }
        //Debug.Log(currentWord);
        return currentWord;
    }

    public void EnterSymbol(string symbol)
    {

        int index = FindNextIndex();
        images[index].ChangeSymbol(symbol);
        if(GetCurrentWord().Length == 5)
        {
            bool result = CheckWord();
            if (result)
            {
                gameContoller.Win();
            }
            else if(currentRow >= maxRow)
            {
                if(maxRow == 5)gameContoller.Lose();
                else
                {
                    gameContoller.MoreTry();
                }
            }
            light.ChangeLight(GetWordButtons(),word);
        }
    }
    public bool CheckWord()
    {
        string currentWord = GetCurrentWord();
        light.ChangeLight(GetWordButtons(), word);
        var arr = GetWordButtons();
        currentRow++;
        foreach (var button in arr)
        {
            if(button.state != CharState.Green)
            {
                
                return false;
            }
        }

        return true;
       
       
    }
    
}
