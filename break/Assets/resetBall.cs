using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class resetBall : MonoBehaviour {
    public GameObject ball;
    private int score;
	// Use this for initialization
	void Start () {
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
        if(collision.gameObject == ball){
            ResetBall();
        }
	}
    void ResetBall(){
        ball.transform.position = new Vector2(0, 0);
        ball.GetComponent<ballMovement>().GoBall();
        print("Score:" + score++ + "On:"+ gameObject.name);
    }
}
