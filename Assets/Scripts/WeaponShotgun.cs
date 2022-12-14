using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShotgun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform[] firePoints;
    private float lastInputTime;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            if (Time.time - lastInputTime > 0.7f) {
                Shoot();
                lastInputTime = Time.time;
            }
        }
    }

    void Shoot() {
        Instantiate(bulletPrefab, firePoints[0].position, firePoints[0].rotation);
        Instantiate(bulletPrefab, firePoints[1].position, firePoints[1].rotation);
        Instantiate(bulletPrefab, firePoints[2].position, firePoints[2].rotation);
    }
}

