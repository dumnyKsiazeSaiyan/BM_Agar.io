using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartColor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = new Color(
            Random.value, 
            Random.value, 
            Random.value);
    }
}
