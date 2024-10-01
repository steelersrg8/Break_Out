using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls: MonoBehaviour
{

    public KeyCode moveLeft = KeyCode.LeftArrow;
    public KeyCode moveRight = KeyCode.RightArrow;
  

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(moveLeft))
        {
            var vel = GetComponent<Rigidbody2D>().velocity;
            vel.x = 6.0f;
            GetComponent<Rigidbody2D>().velocity = vel;
        }
        else if (Input.GetKeyDown(moveRight))
        {
            var vel = GetComponent<Rigidbody2D>().velocity;
            vel.x = -6.0f;
            GetComponent<Rigidbody2D>().velocity = vel;
        }

        else if (!Input.anyKey)
        {
            var vel = GetComponent<Rigidbody2D>().velocity;
            vel.x = 0.0f;
            GetComponent<Rigidbody2D>().velocity = vel;
        }


        if(Input.GetKeyDown(KeyCode.Escape)){

            gameManager.theBall.SendMessage("resetBall");

        }

    }
}