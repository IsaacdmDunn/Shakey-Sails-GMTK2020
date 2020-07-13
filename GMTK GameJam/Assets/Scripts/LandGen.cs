using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandGen : MonoBehaviour
{

    public int timeLeft = 900;
    public GameObject island;
    public GameObject enviromentHandler;
    public int islandSpawnX;
    public int islandSpawnY;


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
            islandSpawnX = Random.Range(-500, 500);
            islandSpawnY = Random.Range(-500, 500);

            while (islandSpawnX < 300)
            {
                islandSpawnX = Random.Range(-500, 500);
            }
            while (islandSpawnX > -300)
            {
                islandSpawnX = Random.Range(-500, 500);
            }
            while (islandSpawnY < 300)
            {
                islandSpawnY = Random.Range(-500, 500);
            }
            while (islandSpawnY > -300)
            {
                islandSpawnY = Random.Range(-500, 500);
            }

            island = Instantiate(island, new Vector3(0, 0, 0), Quaternion.identity);
            island.transform.parent = enviromentHandler.transform;
            timeLeft = Random.Range(0, 900) + 900;
            island.transform.position = new Vector3(islandSpawnX, 0, islandSpawnY);
        }
    }
}
