using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Prefs Prefs;
    public static ButtonScript instance;
    public AudioSource music;
    public Camera MainCamera;
    public int check = 1;
    
    public void Button_Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void Button_Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Button_Pause()
    {
        if (Time.timeScale != 0)
        {
            Time.timeScale = 0;
            music.Pause();
        }
        else
        {
            Time.timeScale = 1;
            music.Play();
        }
    }

    public void Button_Exit()
    {
        Application.Quit();
    }

    public void Button_Start()
    {
        SceneManager.LoadScene("Game");
    }

    public void Button_Music()
    {
        if (check == 1)
        {
            music.Stop();
            check = 0;
        }
        else if (check == 0)
        {
            music.Play();
            check = 1;
        }
    }
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        music = MainCamera.GetComponent<AudioSource>();
    }
}
