using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{

    public float spawnRate = 1;
    [Header("Arrows")]
    public GameObject[] arrows;


    private float lastSpawnTime = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lastSpawnTime + 1 / spawnRate < Time.time)
        {
            lastSpawnTime = Time.time;
            Vector3 spawnPosition = transform.position;
            
            int randomIndex = Random.Range(0, arrows.Length);
            GameObject arrow = Instantiate(arrows[randomIndex], spawnPosition, Quaternion.identity);
        }
    }

    
}
