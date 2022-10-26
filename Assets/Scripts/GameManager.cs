using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject food;
    public GameObject PowerUp_SpeedPrefab;
    public TextMeshProUGUI massText;
    private PlayerController playerController;

    private float startDelay = 0;
    public float spawnRate;

    public int speedy;

    private void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("GenerateFood", startDelay, spawnRate);
    }

    private void Update()
    {
        AddMass();
        SpawnManager();
    }
    void GenerateFood()
    {
        float x = Random.Range(0, Camera.main.pixelWidth);
        float y = Random.Range(0, Camera.main.pixelHeight);
        
        Vector3 randomSpawnPos = Camera.main.ScreenToWorldPoint( new(x, y, 0));
        randomSpawnPos.z = 0;


        Instantiate(food, randomSpawnPos, Quaternion.identity);

    }

    float timer;
    public void AddMass()
    {
        massText.text = "Mass: " + (int)(playerController.transform.localScale.x * 10);

        timer += Time.deltaTime;

        if (playerController.transform.localScale.x > 1.0f && timer >= 0.9f)
        {
            playerController.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
            timer = 0;
        }
    }

    void SpawnManager()
    {
        speedy = GameObject.FindGameObjectsWithTag("PowerUp_Speed").Length;
        float x = Random.Range(0, Camera.main.pixelWidth);
        float y = Random.Range(0, Camera.main.pixelHeight);

        Vector3 randomSpawnPos = Camera.main.ScreenToWorldPoint(new(x, y, 0));
        randomSpawnPos.z = 0;
        if (speedy < 3)
        {
            Instantiate(PowerUp_SpeedPrefab, randomSpawnPos, Quaternion.identity);
        }
    }
}
