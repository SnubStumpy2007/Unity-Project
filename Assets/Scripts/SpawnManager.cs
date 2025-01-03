using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    public float spawnXRangeX = 20;
    public float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        // randomly generate animal index and spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnXRangeX, spawnXRangeX),
            0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation);

    }
}