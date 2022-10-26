using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpeed : MonoBehaviour
{
    public float movementSpeed = 5;
    private float timer;

    private void Update()
    {
        transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
        timer += Time.deltaTime;
        if(timer>= 1.0f)
        {
            int randomDirection = Random.Range(-70, 70);
            transform.Rotate(Vector3.forward * randomDirection) ;
            timer = 0;
        }
    }
}
