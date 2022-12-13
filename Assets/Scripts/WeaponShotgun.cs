using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShotgun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform[] firePoints;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            Shoot();
        }
    }

    void Shoot() {
        Instantiate(bulletPrefab, firePoints[0].position, firePoints[0].rotation);
        Instantiate(bulletPrefab, firePoints[1].position, firePoints[1].rotation);
        Instantiate(bulletPrefab, firePoints[2].position, firePoints[2].rotation);
    }
}

