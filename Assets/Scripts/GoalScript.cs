using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour {

	public string goal;
	public GameObject gameMaster;

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "Ball") {
			gameMaster.GetComponent ("MasterScript").SendMessage ("Score", goal);
		}
	}
}
