using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour {

	public KeyCode moveUp = KeyCode.UpArrow;
	public KeyCode moveDown = KeyCode.DownArrow;

	public float speed = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (moveUp)) {
			var vel = GetComponent<Rigidbody2D>().velocity;
			vel.y = speed;
			GetComponent<Rigidbody2D>().velocity = vel;
		} else if (Input.GetKey (moveDown)) {
			var vel = GetComponent<Rigidbody2D>().velocity;
			vel.y = -1*speed;
			GetComponent<Rigidbody2D>().velocity = vel;;
		} else if(!Input.anyKey){
			var vel = GetComponent<Rigidbody2D>().velocity;
			vel.y = 0.0f;
			GetComponent<Rigidbody2D>().velocity = vel;
		}

		var reset = GetComponent<Rigidbody2D>().velocity;
		reset.x = 0;
		GetComponent<Rigidbody2D>().velocity = reset;

		
	}
}
