using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	public string controller;
	public float padSpeed = 2;
	public float direction;
	public float maxY;
	public float minY;
	public Rigidbody2D rb2d;

	void FixedUpdate () {
		direction = Input.GetAxisRaw (controller);
		if (gameObject.transform.position.y >= maxY && direction != -1) {
			rb2d.velocity = new Vector2 (0, 0); 
			direction = 0;
			gameObject.transform.position = new Vector2 (gameObject.transform.position.x, maxY);
		} else if (gameObject.transform.position.y <= minY && direction != 1) {
			rb2d.velocity = new Vector2 (0, 0); 
			direction = 0; 
			gameObject.transform.position = new Vector2 (gameObject.transform.position.x, minY);
		}
			
		rb2d.velocity = new Vector2 (0, direction * padSpeed);
	}

}
