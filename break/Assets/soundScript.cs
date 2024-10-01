using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawSoundController : MonoBehaviour
{
    AudioSource saw; 

    void Start()
    {
        saw = GameObject.FindObjectOfType<AudioSource>();
    }

    void Update()
    {
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject)
        {
            saw.Play();
            Debug.Log("Nurrrr");
        }
    }
}