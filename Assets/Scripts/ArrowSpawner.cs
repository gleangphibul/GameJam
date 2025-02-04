using UnityEngine;
using System.Collections.Generic;

public class ArrowSpawner : MonoBehaviour
{

    public float spawnRate = 0.5f;
    public float spawnRateIncrease = 0.1f;
    public float maxSpawnRate = 3;
    public float increaseInterval = 6f;

    public GameObject[] arrowDirections;
    public Transform[] spawnPoints;

    private float lastIncreaseTime = 0;
    private float lastSpawnTime = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastIncreaseTime > increaseInterval)
        {
            IncreaseSpawnRate();
            lastIncreaseTime = Time.time;
        }

        if (lastSpawnTime + 1 / spawnRate < Time.time)
        {
            SpawnArrows();
        }

    }

    private void SpawnArrows()
    {
        lastSpawnTime = Time.time;

        int spawnIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[spawnIndex];

        int arrowIndex = Random.Range(0, arrowDirections.Length);
        GameObject arrow = Instantiate(arrowDirections[arrowIndex], spawnPoint.position, Quaternion.identity);

        Arrow newArrow = arrow.GetComponent<Arrow>();
        if (newArrow != null)
        {
            Vector3 arrowDirection = GetSpawnDirection(spawnPoint);
            newArrow.SetDirection(arrowDirection);
        }

                
    }

    private void IncreaseSpawnRate()
    {
        if (spawnRate < maxSpawnRate)
        {
            spawnRate += spawnRateIncrease;
            spawnRate = Mathf.Min(spawnRate, maxSpawnRate); // Prevent exceeding max
        }
    }


    private Vector3 GetSpawnDirection(Transform spawnPoint)
    {
        Vector3 direction = Vector3.zero;
        if (spawnPoint.position.x < 0)
        {
            direction = Vector3.right;
        }
        else if (spawnPoint.position.x > 0)
        {
            direction = Vector3.left;
        } 
        else if (spawnPoint.position.y < 0)
        {
            direction = Vector3.up;
        }
        else if (spawnPoint.position.y > 0)
        {
            direction = Vector3.down;
        }
        return direction;
    }


}
