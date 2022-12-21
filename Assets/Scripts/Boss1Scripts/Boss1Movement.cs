using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float movementSpeed = 400;
    private float minX = -14.2f;
    private float maxX = 14.2f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Movement());

    }


    void Update()
    {

    }

    void FixedUpdate()
    {
        if (transform.position.x >= maxX)
        {
            rb.velocity = new Vector2(-movementSpeed * Time.fixedDeltaTime, rb.velocity.y);
        }
        else if (transform.position.x <= minX)
        {
            rb.velocity = new Vector2(movementSpeed * Time.fixedDeltaTime, rb.velocity.y);
        }
    }

    IEnumerator Movement()
    {
        while (true)
        {
            float randomNum = Random.Range(1, 11);
            if (randomNum <= 5)
            {
                rb.velocity = new Vector2(-movementSpeed * Time.fixedDeltaTime, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(movementSpeed * Time.fixedDeltaTime, rb.velocity.y);
            }
            yield return new WaitForSeconds(1.0f);
        }
    }
}
