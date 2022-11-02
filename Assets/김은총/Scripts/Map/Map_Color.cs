using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Color : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            gameObject.tag = "Red";
            spriteRenderer.material.color = Color.red;
            Debug.Log("»Æ¿Œ");
        }
    }
}
