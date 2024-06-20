using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStyle : MonoBehaviour
{
    public StyleController controllerPref;
    private StyleController controller;
    [SerializeField] private Image background;
    [SerializeField] private Image wordsBackground;
    [SerializeField] private Image keyboardBackground;
    [SerializeField] private CharButton charButton;
    [SerializeField] private CharButton charPlace;

    [SerializeField] private List<Image> panels;
    [SerializeField] private List<Image> buttons;
    void Start()
    {
        controller = FindObjectOfType<StyleController>();
        if (controller == null)
        {
            controller = Instantiate(controllerPref, transform.position, Quaternion.identity);
            DontDestroyOnLoad(controller);
        }
        StyleChange();

    }
    public void StyleChange()
    {
        foreach (var item in panels)
        {
            item.sprite = controller.currentStyle.menuBackground;
        }
        foreach (var item in buttons)
        {
            item.sprite = controller.currentStyle.menuButton;
        }
        background.sprite = controller.currentStyle.background;
        keyboardBackground.sprite = controller.currentStyle.keyboardBackground;
        wordsBackground.sprite = controller.currentStyle.menuBackground;
        charButton.yellow = controller.currentStyle.charButtonYellow;
        charButton.green = controller.currentStyle.charButtonGreen;
        charButton.white = controller.currentStyle.charButtonGray;
        charButton.gameObject.GetComponent<Image>().sprite = controller.currentStyle.charButtonDefault;
        charPlace.yellow = controller.currentStyle.charButtonYellow;
        charPlace.green = controller.currentStyle.charButtonGreen;
        charPlace.white = controller.currentStyle.charButtonGray;
        charPlace.gameObject.GetComponent<Image>().sprite = controller.currentStyle.charButtonDefault;
    }
}
