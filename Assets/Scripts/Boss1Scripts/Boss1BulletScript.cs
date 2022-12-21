using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1BulletScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    
    void Update()
    {
        if (transform.position.y < -ScreenBounds.getScreenBounds().y - 3) {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            Destroy(gameObject);
        }
    }
}
