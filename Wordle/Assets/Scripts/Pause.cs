using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField]private MusicController musicController;
    private void Start()
    {
        musicController = FindObjectOfType<MusicController>();
    }
    public void OnPause()
    {
        musicController.SoundOff();
        Time.timeScale = 0;
    }
    public void UnPause()
    {
        musicController.SoundOn();
        Time.timeScale = 1;
    }
}
