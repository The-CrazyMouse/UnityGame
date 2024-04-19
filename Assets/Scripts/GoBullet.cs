using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBullet : MonoBehaviour
{
    public Transform bulletSpwanPoint;
    public GameObject bulletprefab;
    public float bulletSpeed = 10;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
                var bullet = Instantiate(bulletprefab, bulletSpwanPoint.position, bulletSpwanPoint.rotation);
                bullet.GetComponent<Rigidbody>().velocity = (-bulletSpwanPoint.forward) * bulletSpeed;
        }
    }
}
