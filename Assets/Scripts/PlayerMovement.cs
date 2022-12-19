using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveLeftRight;
    private float moveUpDown;
    public float speed = 400;
    private Vector3 mousePosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveLeftRight = Input.GetAxis("Horizontal");
        moveUpDown = Input.GetAxis("Vertical");

        Vector3 pos = Camera.main.WorldToScreenPoint(rb.transform.position);
        Vector3 dir = Input.mousePosition - pos;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        rb.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(speed * moveLeftRight * Time.fixedDeltaTime, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, speed * moveUpDown * Time.fixedDeltaTime);
    }
}
