using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private void Update()
    {
        Movement();

    }
    void Movement()
    {
        float playerMovementSpeed = 5;
        Vector3 directionMove = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        directionMove.z = 0;

        transform.transform.position = Vector3.MoveTowards(transform.position, directionMove, playerMovementSpeed * Time.deltaTime / transform.localScale.x);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            transform.localScale += other.gameObject.transform.localScale;
            Destroy(other.gameObject);
            Debug.Log("Dzia³a");
        }
    }



}
