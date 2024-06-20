using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MenuStyle : MonoBehaviour
{
    public StyleController controllerPref;
    private StyleController controller;
    [SerializeField] private Image background;
    [SerializeField] private Image menuBackground;
    [SerializeField] private Image line;
    [SerializeField] private Text titleText;
    [SerializeField]private List<Button> menuButtons = new List<Button>();
    
    void Start()
    {
        controller = FindObjectOfType<StyleController>();
        if(controller == null)
        {
            controller = Instantiate(controllerPref,transform.position,Quaternion.identity);
            DontDestroyOnLoad(controller);

           
        }
        controller.currentGameStyle = this;
        StyleChange();

    }
    public void StyleChange()
    {
        background.sprite = controller.currentStyle.background;
        menuBackground.sprite = controller.currentStyle.menuBackground;
        titleText.color = controller.currentStyle.fontColor;
        line.color = controller.currentStyle.fontColor;
        foreach(var button in menuButtons)
        {
            button.gameObject.GetComponent<Image>().sprite = controller.currentStyle.menuButton;
            button.GetComponentInChildren<Text>().color = controller.currentStyle.buttonsTextColor;
        }
    }
    
}
