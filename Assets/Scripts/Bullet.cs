using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //public float life = 3;
    public AudioSource source;
    public Points points;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        source.Play();
    }

    //void Awake()
    //{
        
        //Destroy(gameObject, life);     
        
    //}

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
        points.AddPoint();
    }
}
