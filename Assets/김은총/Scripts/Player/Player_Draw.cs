using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Draw : MonoBehaviour
{
    SpriteRenderer SpriteRenderer;

    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SpriteRenderer.material.color = Color.yellow;
            Debug.Log("»Æ¿Œ");
        }
    }
}