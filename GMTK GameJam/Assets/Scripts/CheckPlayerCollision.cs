using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPlayerCollision : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            SceneManager.LoadScene("GameOver");
        }
        else if (other.gameObject.layer == 9)
        {
            //collect item
        }

    }

}
