﻿using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 15;
    private float spawnPosZ = 20;
    private float[] spawnRangeY = { 0.0f, 15.0f };
    private float spawnPosX = 25;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        int spawnSide = Random.Range(0, 3);
        Vector3 spawnPos;
        if (spawnSide < 1)
        {
            spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        }
        else
        {

            spawnPos = new Vector3( Mathf.Pow(-1, spawnSide) * spawnPosX, 0, Random.Range(spawnRangeY[0], spawnRangeY[1]));
        }
            

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
