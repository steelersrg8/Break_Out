using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftWallCollision : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision!!!!");

        gameManager.Life = gameManager.Life - 1;

        float randY = Random.Range(-4.5f, 4.5f);
        other.gameObject.transform.position = new Vector3(0.0f, randY, 0.0f);
    }

}