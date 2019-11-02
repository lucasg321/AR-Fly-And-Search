using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float xspeed;
    public float yspeed;
    public float zspeed; 

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(xspeed, yspeed, zspeed);
    }
}
