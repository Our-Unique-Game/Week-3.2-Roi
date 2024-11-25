using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckSpawner : MonoBehaviour
{
    public GameObject carPrefab; // The car prefab to spawn
    public Transform spawnPoint; // Fixed spawn location
    public float minSpawnTime = 0.1f; // Minimum time between spawns
    public float maxSpawnTime = 0.5f; // Maximum time between spawns

    void Start()
    {
        StartCoroutine(SpawnCars());
    }

    IEnumerator SpawnCars()
    {
        while (true)
        {
            // Spawn the car at the fixed spawn point
            Instantiate(carPrefab, spawnPoint.position, spawnPoint.rotation);

            // Wait for a random time interval before the next spawn
            float randomInterval = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(randomInterval);
        }
    }
}
