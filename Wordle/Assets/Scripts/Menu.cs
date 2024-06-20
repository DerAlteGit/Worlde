using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField]private MusicController musicController;
    private void Start()
    {
        if(FindObjectOfType<MusicController>() == null)
        {
            var controller = Instantiate(musicController,transform.position,Quaternion.identity);
            DontDestroyOnLoad(controller.gameObject);
        }
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
