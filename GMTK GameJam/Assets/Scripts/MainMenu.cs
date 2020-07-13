using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource buttonPress;
    public GameObject helpMenu;

    public void PlayButton()
    {
        buttonPress.Play();
        SceneManager.LoadScene("GameScene");
    }
    public void HowToPlayButton()
    {
        buttonPress.Play();
        helpMenu.SetActive(true);
    }
    public void HowToPlayMenuExit()
    {
        buttonPress.Play();
        helpMenu.SetActive(false);
    }
    public void QuitButton()
    {
        buttonPress.Play();
        Application.Quit();
    }
}
