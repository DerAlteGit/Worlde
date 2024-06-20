using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    //[SerializeField] private List<UIStyle> styles;
    public StyleController controllerPref;
    private StyleController styleController;
    [SerializeField] private Image preview;
    [SerializeField] private Text moneyText;
    [SerializeField] private Button buyButton;
    [SerializeField] private Button chouseButton;
    [SerializeField] private PlayerMoney money;
    private int currentIndex;
    private void Start()
    {
        styleController = FindObjectOfType<StyleController>();
        if (styleController == null)
        {
            styleController = Instantiate(controllerPref, transform.position, Quaternion.identity);
            DontDestroyOnLoad(styleController);
        }
        currentIndex = PlayerPrefs.GetInt("Style");
        UpdateUI();
    }

    public void Next()
    {
        if(currentIndex + 1 < styleController.styles.Count)
        {
            currentIndex++;
        }
        else
        {
            currentIndex = 0;
        }
        UpdateUI();
    }
    public void Previous()
    {
        if (currentIndex - 1 >= 0)
        {
            currentIndex--;
        }
        else
        {
            currentIndex = styleController.styles.Count - 1;
        }

        UpdateUI();
    }
    public void Choose()
    {
        styleController.ChangeStyle(currentIndex);
        UpdateUI();
    }
    public void Buy()
    {
        if (money.SpendMoney(styleController.styles[currentIndex].cost))
        {
            styleController.styles[currentIndex].isBought = true;
        }
        UpdateUI();
    }
    public void UpdateUI()
    {
        moneyText.text = PlayerPrefs.GetInt("Money").ToString();
        if (!styleController.styles[currentIndex].isBought)
        {
            chouseButton.gameObject.SetActive(false);
            buyButton.gameObject.SetActive(true);
            buyButton.GetComponentInChildren<Text>().text = styleController.styles[currentIndex].cost.ToString();
        }
        else
        {
            buyButton.gameObject.SetActive(false);
            chouseButton.gameObject.SetActive(true);
            if (styleController.currentStyle == styleController.styles[currentIndex]) chouseButton.GetComponentInChildren<Text>().text = "�������";
            else
            {
                chouseButton.GetComponentInChildren<Text>().text = "�������";

            }
        }
        preview.sprite = styleController.styles[currentIndex].background;
    }
}
