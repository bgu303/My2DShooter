using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void Update()
    {
        if (transform.position.x < ScreenBounds.getScreenBounds().x - 35 || transform.position.x > ScreenBounds.getScreenBounds().x + 3 || transform.position.y < ScreenBounds.getScreenBounds().y - 17 || transform.position.y > ScreenBounds.getScreenBounds().y + 3)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (EnemyList.tags.Contains(other.gameObject.tag))
        {
            Destroy(gameObject);
        }
    }
}
