using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomObj : MonoBehaviour
{

    public GameObject[] blockingObjects;
    int randomObject;

    int randomPause;
    int pauseTime = 100;
    int maxPauseTime = 100;

    // Start is called before the first frame update
    void Start()
    {
        randomObject = Random.Range(0, 7);    
    }

    // Update is called once per frame
    void Update()
    {
        pauseTime -= 1; 

        if(pauseTime <= 1)
        {
            pauseTime = maxPauseTime;
        }

        if (randomPause == 1 && pauseTime <=10)
        {
            randomObject = Random.Range(0, 4);
            Instantiate(blockingObjects[randomObject]);
            randomPause = 0;
        }else if (randomPause == 0 && pauseTime <= 10)
        {
            randomObject = Random.Range(3, 7);
            Instantiate(blockingObjects[randomObject]);
            randomPause = 1;
        }
    }
}
