
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transform : MonoBehaviour
{
    public GameObject[] CactusPrefabs; 
    public Transform spawnPoint; 

    private int selectedCactusIndex;
    private bool readyToSpawn = false;

    void Start()
    {
        StartCoroutine(SpawnCacti()); 
    }
    IEnumerator SpawnCacti()
    {
        while (true)
        {
            yield return new WaitForSeconds(GetSpawnTime());

            readyToSpawn = true;

            if (readyToSpawn)
            {
                SpawnCactus();
            }
        }
    }

    float GetSpawnTime()
    {
        float score = Control.scorevalue; 
        float spawnTime = 0f;

        if (score < 200)
        {
            spawnTime = Random.Range(3f, 5f);
        }
        else if (score < 1000)
        {
            spawnTime = Random.Range(1f, 3f);
        }
        else if (score < 5000)
        {
            spawnTime = Random.Range(0f, 1f);
        }

        return spawnTime;
    }

    void SpawnCactus()
    {
        selectedCactusIndex = Random.Range(0, CactusPrefabs.Length);
        Instantiate(CactusPrefabs[selectedCactusIndex], spawnPoint.position, transform.rotation);
        readyToSpawn = false;
    }
}