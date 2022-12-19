using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 20;
    public GameObject player;
    private Vector2 target;
    private Rigidbody2D rb;
    public float currentHp;
    public float maxHp;
    public HealthbarBehavior healthbar;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        Vector3 direction = player.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Bullet"))
        {
            currentHp -= 50;
            healthbar.TakeDamage();
        }
        if (currentHp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
