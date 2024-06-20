using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicController : MonoBehaviour
{
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private Sprite soundOn;
    [SerializeField] private Sprite soundOff;
    [SerializeField] private Image soundButton;
    private void Start()
    {
        if(PlayerPrefs.GetInt("Music") == 0 && soundButton.sprite != soundOff)
        {
            ChangeSound();
        }
        else if(PlayerPrefs.GetInt("Music") == 1 && soundButton.sprite != soundOn)
        {
            ChangeSound();
        }
        DontDestroyOnLoad(gameObject);
   
    }
    public void ChangeSound()
    {
        AudioSource[] audios = FindObjectsByType<AudioSource>(FindObjectsSortMode.None);
        if(soundButton.sprite == soundOff)
        {
            soundButton.sprite = soundOn;
            foreach (var item in audios)
            {
                item.mute = false;
                PlayerPrefs.SetInt("Music", 1);
            }
            return;
        }
        foreach (var item in audios)
        {
            item.mute = true;
            PlayerPrefs.SetInt("Music", 0);
        }
        soundButton.sprite = soundOff;
    }
   
}
