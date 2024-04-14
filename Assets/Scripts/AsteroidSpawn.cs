using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour
{
    // Update is called once per frame
    public GameObject asteroid;

    void Update()
    {
        for(int i = 0; i<6; i++){
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Vector3 randomSpawnPosition = new Vector3(Random.Range(-48, 48), 3.484f, -100);
                Instantiate(asteroid, randomSpawnPosition, Quaternion.identity);
            }
        }
    }
}
