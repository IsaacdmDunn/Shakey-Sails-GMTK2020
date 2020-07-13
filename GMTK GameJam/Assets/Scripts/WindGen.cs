using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class WindGen : MonoBehaviour
{
    public static Vector3 windDirection = new Vector3(3, 0, 3);
    public static float windSpeed = 1000;
    public float pubWindSpeed;
    public int timeLeft = 1000;
    //public LandMovement land;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft--;

        if (timeLeft < 0)
        {
            windDirection = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            timeLeft = Random.Range(0, 1500) + 500;
            windSpeed = Random.Range(0, 1000) + 500;
            pubWindSpeed = windSpeed;
        }
    }
}
