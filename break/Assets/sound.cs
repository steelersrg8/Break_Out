using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    AudioSource saw;
    // Use this for initialization
    void Start()

    {
        saw = GameObject.FindObjectOfType<AudioSource>();
    }

    void Update()
    {
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject)
        {
            saw.Play();
            Debug.Log("Nurrrr");
        }
    }
}