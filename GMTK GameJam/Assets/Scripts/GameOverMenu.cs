using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public Text scoreTXT;
    public AudioSource buttonPress;

    public void Start()
    {
        buttonPress.Play();
        scoreTXT.text = "Score: " + Score.score.ToString();
    }
    public void PlayAgainButton()
    {
        buttonPress.Play();
        SceneManager.LoadScene("GameScene");
    }
    public void QuitButton()
    {
        buttonPress.Play();
        Application.Quit();
    }
}
