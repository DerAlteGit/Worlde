using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public enum CharState
{
    Green,
    Yellow,
    White
}
public class CharButton : MonoBehaviour
{
    [field: SerializeField] public string Symbol { get; private set; }
    public CharState state;
    [SerializeField] private Text text;
    [SerializeField]private Image spriteRenderer;
    [SerializeField] public Sprite green;
    [SerializeField] public Sprite yellow;
    [SerializeField] public Sprite white;
    private void Start()
    {
        StyleController controller = FindObjectOfType<StyleController>();
        green = controller.currentStyle.charButtonGreen;
        yellow = controller.currentStyle.charButtonYellow;
        white = controller.currentStyle.charButtonGray;
        spriteRenderer.sprite = controller.currentStyle.charButtonDefault;
    }

    public void ChangeColor(CharState state)
    {
        this.state = state;
        switch (state)
        {
            case CharState.Green:
                spriteRenderer.sprite = green;
                break;
            case CharState.Yellow:
                spriteRenderer.sprite = yellow;
                break;
            case CharState.White:
                spriteRenderer.sprite = white;
                break;

        }
    }
    public void ChangeSymbol(string symbol)
    {
        Symbol = symbol.ToString();
        text.text = symbol.ToString();
    }
}
