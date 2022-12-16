using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarBehavior : MonoBehaviour
{
    
    public Slider slider;
    public Vector3 offSet;
    public EnemyMovement healthbar;

    void Start()
    {
        slider.maxValue = healthbar.maxHp;
    }

    void Update()
    {
        slider.transform.position = Camera.main.WorldToScreenPoint(transform.position + offSet);
        slider.value = healthbar.currentHp;
    }
}
