using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController movement;
    public GoBullet gun; 

    private void OnCollisionEnter(Collision collision)
    {
        
            Debug.Log("cli");
            if (collision.gameObject.CompareTag("Enemy"))
            {
                    movement.enabled = false;
                    Destroy(gun.bulletSpwanPoint);
                    FindObjectOfType<GameManager>().GameOver();
            }
            
            
    }
}
