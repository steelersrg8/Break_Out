using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement1 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        goBall();
    }

    void goBall()
    {
        float rand = Random.Range(-10.0f, 10.0f);
        if (rand <= 0.0f)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-10.0f, -10.0f));
        }
        else
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(10.0f, -10.0f));
        }
    }

    void resetBall()
    {
        //stop the ball
        var vel = GetComponent<Rigidbody2D>().velocity;
        vel.x = 0.0f;
        vel.y = 0.0f;
        GetComponent<Rigidbody2D>().velocity = vel;

        //reposition the ball
        float randY = Random.Range(0f, 0f);
        gameObject.transform.position = new Vector2(0, 0);

        //push the ball again
        goBall();
    }

    void hasWon()
    {
        //stop the ball
        var vel = GetComponent<Rigidbody2D>().velocity;
        vel.x = 0.0f;
        vel.y = 0.0f;
        GetComponent<Rigidbody2D>().velocity = vel;

        //reposition the ball
        gameObject.transform.position = new Vector2(0, 0);

    }
    void ResetBall()
    {
        var vel = GetComponent<Rigidbody2D>().velocity;
        vel.x = 0.0f;
        vel.y = 0.0f;
        GetComponent<Rigidbody2D>().velocity = vel;

        gameObject.transform.position = new Vector3(0, 0, 0);

        print("Score:" + gameManager.score++ + "On:" + gameObject.name);
        goBall();
    }
}
  




	// Update is called once per frame

