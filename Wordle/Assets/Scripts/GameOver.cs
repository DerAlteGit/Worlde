using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private WinPanel winPanel;
    [SerializeField] private LosePanel losePanel;
    [SerializeField] private GameObject moreTryPanel;
    [SerializeField] private GameObject keyboard;
    [SerializeField] private WordsContainer container;
    public event Action onLose;

    private float currentTime;
    private void Update()
    {
        currentTime += Time.deltaTime;
    }
    public void MoreTry()
    {
        moreTryPanel.SetActive(true);
    }
    public void Lose()
    {
        losePanel.gameObject.SetActive(true);
        losePanel.word = container.Word;
        losePanel.Init();
        keyboard.SetActive(false);
       
    }
    public void Win()
    {
        keyboard.SetActive(false);
        winPanel.gameObject.SetActive(true);
        winPanel.word = container.Word;
        winPanel.time = (int)Mathf.Round(currentTime);
        if(winPanel.time < PlayerPrefs.GetInt("Record"))
        {
            PlayerPrefs.SetInt("Record", winPanel.time);
        }
        winPanel.recordTime = PlayerPrefs.GetInt("Record");
        winPanel.Init();
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
