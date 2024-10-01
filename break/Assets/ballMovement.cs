using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ballMovement : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        GoBall();
    }
    public void GoBall(){
        float rand = Random.Range(-10f, 10f);
        if (rand <= 0.0f)
        {
            //move the ball to the left
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-10.0f, -10.0f));
        }
        else
        {
            //move the ball to the right
            GetComponent<Rigidbody2D>().AddForce(new Vector2(10.0f, -10.0f));
        }
    }

    // Update is called once per frame
    void Update()
    {
        {
            float rand = Random.Range(-1.5f, 1.5f);
            if (rand <= 0.0f)
            {
                //move the ball to the left
                GetComponent<Rigidbody2D>().AddForce(new Vector2(-5.0f, -5.0f));
            }
            else
            {
                //move the ball to the right
                GetComponent<Rigidbody2D>().AddForce(new Vector2(5.0f, -5.0f));
            }
        }
    }
}


