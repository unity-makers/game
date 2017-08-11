using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMainCamera : MonoBehaviour {

    public GameObject mc;
    public float speed;

	// Use this for initialization
	void Start () {
        mc = GameObject.Find("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            mc.transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            mc.transform.Translate(new Vector3(0, 0, -1 * speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            mc.transform.Rotate(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            mc.transform.Rotate(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            mc.transform.Rotate(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            mc.transform.Rotate(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            mc.transform.Translate(new Vector3(0, 1 * speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            mc.transform.Translate(new Vector3(0, -1 * speed * Time.deltaTime, 0));
        }
    }
}