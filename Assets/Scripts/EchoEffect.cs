using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoEffect : MonoBehaviour
{
    private PowerUpSpeed powerUpSpeed;
    public float timeBtwEcho;
    private float timeToNextEcho;

    public GameObject echo;

    private void Start()
    {
        powerUpSpeed = GetComponent<PowerUpSpeed>();
        timeBtwEcho = powerUpSpeed.movementSpeed / 50;
    }
    void Update()
    {
        if(timeToNextEcho <= 0)
        {
            GameObject instance = (GameObject) Instantiate(echo, transform.position, transform.rotation);
            Destroy(instance, 1);
            timeToNextEcho = timeBtwEcho;

        }
        else
        {
            timeToNextEcho -= Time.deltaTime;
        }
    }
}
