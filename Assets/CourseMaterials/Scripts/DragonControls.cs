using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragonControls : MonoBehaviour {

    // Use this for initialization

    public Transform Dragon;
    public float moveSpeed;
    public Joystick joystick;


    public Scrollbar scrollbar;

    float OriginalY = 0;

   
    private void Start()
    {
        OriginalY = Dragon.transform.position.y;
     
    }

    void Update()
    {
        Vector3 moveVector = (transform.right * joystick.Horizontal + transform.forward * joystick.Vertical).normalized;
        Dragon.transform.Translate(Vector3.forward * Mathf.Clamp( joystick.Vertical*6 , -1,1)* moveSpeed * Time.deltaTime);
        Dragon.transform.Rotate(Vector3.up * joystick.Horizontal * 66 * Time.deltaTime);



        Dragon.transform.position = new Vector3(Dragon.transform.position.x, OriginalY+scrollbar.value, Dragon.transform.position.z);
    }

    
    public void ToggleDragonFlame()
    {
        InvokeRepeating("DragonFlame",0, 2);

    }


    void DragonFlame()
    {
        Dragon.transform.Find("DragonFlame").transform.localPosition = new Vector3(0, 0.384f, 0.18f);

        if (Dragon.transform.Find("DragonFlame").gameObject.activeSelf == false)
        {
            Dragon.transform.Find("DragonFlame").gameObject.SetActive(true);
            return;
        }

        if (Dragon.transform.Find("DragonFlame").gameObject.activeSelf == true)
        {
            Dragon.transform.Find("DragonFlame").gameObject.SetActive(false);
            CancelInvoke("DragonFlame");
        }
     
    }


}
