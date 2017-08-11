using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour {

    public int flag = 0;
    public GameObject mc;

	// Use this for initialization
	void Start () {
        mc.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Clicked_Menu();
        }
    }

    public void Clicked_Menu()
    {
        flag++;
        if (flag % 2 == 1)
            mc.SetActive(true);
        else
            mc.SetActive(false);
    }
}
