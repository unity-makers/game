using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movie : MonoBehaviour {

    // Use this for initialization
    public MovieTexture movTexture;

    void Start()
    {
        //设置电影纹理播放模式为循环
        Renderer rend;
        rend = GetComponent<Renderer>();
        rend.material.mainTexture = movTexture;
        movTexture.loop = true;
        movTexture.Play();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
