using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class LandMovement : WindGen
{
    public Vector3 movement;
    float islandPosX;
    float islandPosY;
    
    // Start is called before the first frame update
    void Start()
    {
        //windSpeed = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        
        movement = windDirection * windSpeed * 0.0001f;
        transform.position += movement;

        if (transform.position.x < -500 || transform.position.x > 500 || transform.position.z < -500 || transform.position.z > 500)
        {
            islandPosX = Random.Range(-500, 500);
            islandPosY = Random.Range(-500, 500);

            while (islandPosX < 300)
            {
                islandPosX = Random.Range(-500, 500);
            }
            while (islandPosX > -300)
            {
                islandPosX = Random.Range(-500, 500);
            }
            while (islandPosY < 300)
            {
                islandPosY = Random.Range(-500, 500);
            }
            while (islandPosY > -300)
            {
                islandPosY = Random.Range(-500, 500);
            }
            transform.position = new Vector3(islandPosX, 0, islandPosY);
        }
    }
}
