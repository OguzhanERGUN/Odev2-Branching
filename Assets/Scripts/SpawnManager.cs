using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] AnimalPrefabs;
    private int animalIndex;
    public float spawnRangeX;
    Quaternion rotation = Quaternion.Euler(0, -90, 0);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        animalIndex = Random.Range(0, AnimalPrefabs.Length);
        Vector3 SpawnPosX = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, 30);
        Instantiate(AnimalPrefabs[animalIndex], SpawnPosX, AnimalPrefabs[0].transform.rotation);



        animalIndex = Random.Range(0, AnimalPrefabs.Length);
        Vector3 SpawnPosZ = new Vector3(20, 0, Random.Range(7, 17));
        Instantiate(AnimalPrefabs[animalIndex], SpawnPosZ, rotation);

    }
}
