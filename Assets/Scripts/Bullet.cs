using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public AudioSource source;
    private Points points;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        source.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject points = GameObject.Find("ScoreOnScreen");
        points.GetComponent<Points>().AddPoint();
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
