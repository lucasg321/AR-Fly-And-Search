using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncTimeOnHit : MonoBehaviour
{
    Vector3 originalpos;

    public TimeKeeper timeKeeper;
    public ScoreKeeper scoreKeeper; 

    // Start is called before the first frame update
    void Start()
    {
        originalpos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.CompareTag("Dragon"))
        {
            transform.localPosition = originalpos;
            timeKeeper.currentTime = timeKeeper.currentTime + 15;
            scoreKeeper.currentScore = scoreKeeper.currentScore + 1; 
        }
    }
}
