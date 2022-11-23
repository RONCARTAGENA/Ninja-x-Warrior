using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaclespawner : MonoBehaviour
{
    public GameObject stoneground;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public float TimeBetweenSpawn;
    private float SpawnTime;

    void Update()
    {

        if(Time.time > SpawnTime)
        {
            spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
        }   
    }

    void spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(stoneground, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
