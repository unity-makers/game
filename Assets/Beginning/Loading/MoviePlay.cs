using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviePlay : MonoBehaviour {

    //电影纹理
    public MovieTexture movTexture;

    void Start()
    {
        //设置电影纹理播放模式为循环
        movTexture.loop = true;
        movTexture.Play();
    }

    void OnGUI()
    {
        //绘制电影纹理
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), movTexture, ScaleMode.StretchToFill);
        
        
    }
}
