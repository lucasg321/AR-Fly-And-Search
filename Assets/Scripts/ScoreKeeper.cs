using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ScoreKeeper : MonoBehaviour
{
    public int currentScore; 

    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = currentScore.ToString("0");
    }
}
