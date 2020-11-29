using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformPrefab;

    public int numberOfPlatforms = 200;

    public float levelWidth = 3f;
    public float minY = .3f;
    public float maxY = 1.5f;
            
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        //a loop to specify what number of platforms will be generated and where
        for (int i = 0; i < numberOfPlatforms;  i++)
        {
            //when platforms are created they increase between the two values specified on y
            spawnPosition.y += Random.Range(minY, maxY);
            //when platforms are created they increase between the two values specified on x
            spawnPosition.x = Random.Range(-levelWidth, +levelWidth);
            //create platforms in this position and rotation
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
