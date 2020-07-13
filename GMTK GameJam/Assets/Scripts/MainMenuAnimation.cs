using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuAnimation : MonoBehaviour
{
    public float shipRotationX;
    public float shipRotationZ;
    public float shipPosY;

    public bool goingUp = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (goingUp == true)
        {
            shipRotationX += 0.015f;
        }
        else if (goingUp == false)
        {
            shipRotationX -= 0.015f;
        }

        if (goingUp == true)
        {
            shipRotationZ += 0.015f;
        }
        else if (goingUp == false)
        {
            shipRotationZ -= 0.015f;
        }
        if (goingUp == true)
        {
            shipPosY += 0.006f;
        }
        else if (goingUp == false)
        {
            shipPosY -= 0.006f;
        }
        if (shipRotationX >= 3f)
        {
            goingUp = false;
        }
        else if (shipRotationX <= -3.6f)
        {
            goingUp = true;
        }

        transform.rotation = Quaternion.Euler(shipRotationX, -120, shipRotationZ);
        transform.position = new Vector3(0, shipPosY - 3f, 128);
    }
}
