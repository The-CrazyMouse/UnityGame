using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //public float life = 3;
    public AudioSource source;
    private Points points;

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
        GameObject points = GameObject.Find("ScoreOnScreen");
        points.GetComponent<Points>().AddPoint();
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
