using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControls : MonoBehaviour
{
    public GameObject Ship;
    public GameObject enviroment;
    public float yAngle;
    public float yHullAngle;
    public float turningSpeed = 0.01f;
    public float drag = 0.006f;
    public float maxTurnSpeed = 1.2f;

    public float shipRotationX;
    public float shipRotationZ;
    public bool goingUp = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E) && turningSpeed < maxTurnSpeed)
        {
            yAngle += turningSpeed;

        }
        else if (Input.GetKey(KeyCode.Q) && turningSpeed > -maxTurnSpeed)
        {
            yAngle -= turningSpeed;

        }
        if (yAngle > 0)
        {
            yAngle -= drag;
        }
        else if (yAngle < 0)
        {
            yAngle += drag;
        }

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
        if (shipRotationX >= 3f)
        {
            goingUp = false;
        }
        else if (shipRotationX <= -3.6f)
        {
            goingUp = true;
        }

        Ship.transform.rotation = Quaternion.Euler(shipRotationX, yAngle + 180, shipRotationZ);
        enviroment.transform.Rotate(0, yAngle, 0, 0);
    }
}