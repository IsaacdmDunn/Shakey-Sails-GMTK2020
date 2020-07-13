using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    public Text scoreTXT;
    public Text windTXT;
    public Text windDirectionTXT;
    public Image windIMG;
    public AudioSource buttonPress;

    float windAngle;

    // Start is called before the first frame update
    void Start()
    {
        windIMG.transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
        UpdateWind();
    }

    public void QuitButton()
    {
        buttonPress.Play();
        Application.Quit();
    }

    public void UpdateScore()
    {
        Score.score += 1;
        scoreTXT.text = "Score: " + Score.score.ToString();
    }
    
    public void UpdateWind()
    {
        windTXT.text = "Wind Speed: " + (WindGen.windSpeed / 10).ToString() + "/ms";

        windAngle = Mathf.Atan2(WindGen.windDirection.x, WindGen.windDirection.z) * Mathf.Rad2Deg;

        windDirectionTXT.text = "Wind Angle: " + windAngle + "°";
        windIMG.transform.rotation = Quaternion.Euler(60, 0, windAngle);
    }
}
