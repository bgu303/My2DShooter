using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarBehavior : MonoBehaviour
{
    public Slider slider;
    public Vector3 offSet;
    public float currentHp;
    public float maxHp;
    public HighScore highScore;

    void Start()
    {
        slider.maxValue = maxHp;
        slider.value = currentHp;
        highScore = GameObject.Find("HighScore").GetComponent<HighScore>();
    }

    void Update()
    {
        slider.transform.position = Camera.main.WorldToScreenPoint(transform.position + offSet);
    }

    public void TakeDamage()
    {
        slider.value = currentHp;
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
            TakeDamage();
        }
        if (currentHp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if (gameObject.tag == "Enemy")
        {
            highScore.AddPoints(10);
        }
        else if (gameObject.tag == "EnemyFast")
        {
            highScore.AddPoints(5);
        }
        else if (gameObject.tag == "EnemyTank")
        {
            highScore.AddPoints(20);
        }
        Destroy(gameObject);
    }
}
