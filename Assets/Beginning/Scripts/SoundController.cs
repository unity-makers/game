using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour {

	public AudioSource audio;
	public Slider soundSlider;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ChageSound(){
		float value = soundSlider.value;
		audio.volume = value;
	}
}
