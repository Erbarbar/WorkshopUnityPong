using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterScript : MonoBehaviour {


	public int victoryScore;
	public float ballVelocity = 20;
	public GameObject prefab;
	private GameObject ball;
	private int p1Score;
	private int p2Score;
	public Text textScore1;
	public Text textScore2;
	public Text victoryText;

	// Use this for initialization
	void Start () {
		victoryText.text = "";
		p1Score = 0;
		p2Score = 0;
		newBall ();
	}
	
	// Update is called once per frame
	void Update () {
		textScore1.text = p1Score.ToString ();
		textScore2.text = p2Score.ToString ();
	}

	bool checkVictory(){
		if (p1Score == victoryScore) {
			victoryText.text = "Player 1 Wins!";
			return true;
		} 
		if (p2Score == victoryScore) {
			victoryText.text = "Player 2 Wins!";
			return true;
		}
		return false;
	}

	void Score(string goal){
		switch (goal) {
		case "right":
			p1Score++;
			break;
		case "left":
			p2Score++;
			break;
		default:
			break;
		}
		Destroy (ball);
		if (!checkVictory ()) {
			newBall ();
		}
	}

	void newBall(){
		ball = Instantiate (prefab, new Vector2 (0,0), Quaternion.identity);
		Rigidbody2D rb2d = (Rigidbody2D) ball.GetComponent ("Rigidbody2D");
		rb2d.AddForce (new Vector2 (ballVelocity, 0), ForceMode2D.Impulse);
		rb2d.AddTorque (10);
	}

}
