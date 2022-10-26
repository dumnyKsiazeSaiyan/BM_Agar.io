using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerMovementSpeed = 5;
    
    private void Update()
    {
        Movement();

    }
    void Movement()
    {
        Vector2 directionMove = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        

        transform.transform.position = Vector3.MoveTowards(transform.position, directionMove, playerMovementSpeed * Time.deltaTime / (transform.localScale.x * 0.9f));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            transform.localScale += other.gameObject.transform.localScale;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("PowerUp_Speed"))
        {
            playerMovementSpeed += 3;
            Destroy(other.gameObject);
        }
    }



}
