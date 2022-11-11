using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float speed;

    public Vector2 randomDir;

    Rigidbody2D rigid;

    Vector3 lastVelocity;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        rigid.AddForce(randomDir.normalized * speed, ForceMode2D.Impulse);

        Invoke("DestroyBall", 10);
    }

    private void Update()
    {
        lastVelocity = rigid.velocity;
    }

    private void DestroyBall()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Wall"))
        {
            var speed = lastVelocity.magnitude;
            var dir = Vector2.Reflect(lastVelocity.normalized, coll.contacts[0].normal);

            rigid.velocity = dir * Mathf.Max(speed, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            collision.gameObject.GetComponent<Player1_Item>().HitBall();
            Destroy(gameObject);
        }
    }
}
