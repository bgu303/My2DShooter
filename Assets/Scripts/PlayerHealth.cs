using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float currentHp = 100;
    public float maxHp = 100;
    public Slider slider;
    public GameOverScreen GameOverScreen;

    void Start()
    {
        slider.value = currentHp;
    }

    void Update()
    {

    }

    void takeDamage(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            currentHp -= 20;
            slider.value = currentHp;
        }
        else if (other.gameObject.CompareTag("EnemyFast"))
        {
            currentHp -= 15;
            slider.value = currentHp;
        }
        else if (other.gameObject.CompareTag("EnemyTank"))
        {
            currentHp -= 30;
            slider.value = currentHp;
        }
        if (currentHp <= 0)
        {
            GameOverScreen.ActivateScreen();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        takeDamage(other);
    }
}
