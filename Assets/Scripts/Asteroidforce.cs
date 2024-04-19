using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Asteroidforce : MonoBehaviour
{
    private Rigidbody rb;
    public double forwardforce; 
    public float countdown = 99999f;
    private Points points;

    public float rotationSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, (float)(forwardforce * Time.deltaTime), ForceMode.VelocityChange);
        transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    } 
    private void Update()
    {
        if (gameObject.transform.position.z > 180)
        {
            GameObject points = GameObject.Find("ScoreOnScreen");
            points.GetComponent<Points>().LosePoint();
            Destroy(gameObject);
        }

    }

    public double getForce()
    {
        return forwardforce;
    }

    public void setForce(double force)
    {
        this.forwardforce = force;
    }
} 
