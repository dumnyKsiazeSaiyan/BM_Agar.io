using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject food;

    private float startDelay = 0;
    public float spawnRate;

    private void Start()
    {
        InvokeRepeating("GenerateFood", startDelay, spawnRate);
    }

    void GenerateFood()
    {
        float x = Random.Range(0, Camera.main.pixelWidth);
        float y = Random.Range(0, Camera.main.pixelHeight);
        
        Vector3 randomSpawnPos = Camera.main.ScreenToWorldPoint( new(x, y, 0));
        randomSpawnPos.z = 0;


        Instantiate(food, randomSpawnPos, Quaternion.identity);

    }
}
