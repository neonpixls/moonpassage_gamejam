using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformsPrefabs;

    public int numberOfPlatforms;

    public float levelWidth = 5.0f;
    public float minY = 1.5f;
    public float maxY = 2.5f;   
    
    void Start()
    {
        Vector3 spawnPosition = new Vector3();        

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformsPrefabs, spawnPosition, Quaternion.identity);
            
        }
    }
}
