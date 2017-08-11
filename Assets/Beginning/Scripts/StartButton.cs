using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartButton : MonoBehaviour {
    public Camera cam;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Click_Start(){
		//Add code here for Start
		SceneManager.LoadSceneAsync("Game");
        cam.GetComponent<MoviePlay>().enabled = true;

    }
}
