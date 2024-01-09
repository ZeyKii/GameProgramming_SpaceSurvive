using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public GameObject target;
    public float spawnInterval = 2f;
    public float asteroidSpeed = 0.2f;
    public float intervalDecrement = 0.1f;
    public float speedIncrement = 0.5f;
    public float minimumInterval = 0.5f;
    public float startDelay = 0f;

    private float nextSpawnTime;
    private bool gameStarted = false;

    void Start()
    {
        nextSpawnTime = Time.time + startDelay;
    }

    void Update()
    {
        if (!gameStarted && Time.time >= nextSpawnTime)
        {
            gameStarted = true;
            nextSpawnTime = Time.time + spawnInterval;
        }

        if (gameStarted && Time.time >= nextSpawnTime)
        {
            SpawnAsteroid();
            AdjustSpawnRate();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    void SpawnAsteroid()
    {
        GameObject asteroid = Instantiate(asteroidPrefab, transform.position, Quaternion.identity);
        Vector2 direction = (target.transform.position - transform.position).normalized;
        Debug.Log(direction);
        asteroid.GetComponent<Rigidbody2D>().velocity = direction * asteroidSpeed;
    }

    void AdjustSpawnRate()
    {
        if (spawnInterval > minimumInterval)
        {
            spawnInterval -= intervalDecrement;
            asteroidSpeed += speedIncrement;
        }
    }
}
