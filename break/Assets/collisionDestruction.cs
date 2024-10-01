using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDestruction : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called 
    void OnCollisionEnter2D(Collision2D other)
    {
        gameManager.score = gameManager.score + 1;
        Destroy(this.gameObject);

    }

    void DestroyBrick(){
        Destroy(this.gameObject);

    }
}