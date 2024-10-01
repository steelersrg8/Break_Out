using UnityEngine;
using System.Collections;

public class TennisBall : MonoBehaviour {

	void Start () {

		float rand = Random.Range (-20.0f,20.0f);
		if (rand < 0.0f) {
			GetComponent<Rigidbody2D>().AddForce(new Vector2(rand,-15.0f));
		} else {
			GetComponent<Rigidbody2D>().AddForce(new Vector2(-rand,15.0f));
		}
	}

}
