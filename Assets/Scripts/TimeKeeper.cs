using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class TimeKeeper : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 60f;

    public Text count;

    GameObject gameOver; 
    // Start is called before the first frame update
    void Start()
    {
        gameOver = GameObject.Find("GameOver");
        gameOver.SetActive(false);
        currentTime = startingTime; 
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        count.text = currentTime.ToString("0"); 

        if (currentTime <= 0)
        {
            currentTime = 0;
            gameOver.SetActive(true);
        }
    }
}
