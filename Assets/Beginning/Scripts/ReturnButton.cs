using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnButton : MonoBehaviour {

    // Use this for initialization
    public Camera mainCamera;
    public float speed = 5;
    public float temp = 0;
    public bool flag = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            temp += 5;
            if (temp > 90)
            {
                flag = false;
                temp = 0;
            }
            else mainCamera.transform.Rotate(0, -5, 0);
        }
    }

    public void Click_Return()
    {
        //Add code here for Return
        flag = true;
    }
}
