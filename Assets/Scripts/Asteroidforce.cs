using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroidforce : MonoBehaviour
{
    private Rigidbody rb;
    public float forwardforce; 
    public float countdown = 99999f;
    public Points points;

    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // FixedUpdate is called at fixed intervals
    void FixedUpdate()
    {
        // Apply force along the z-axis in the forward direction
        rb.AddForce(0, 0, forwardforce * Time.deltaTime, ForceMode.VelocityChange);
        transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    } 
    private void Update()
    {
        if (gameObject.transform.position.z > 180)
        {
            Destroy(gameObject);
            points.LosePoint();
        }

    }
} 
