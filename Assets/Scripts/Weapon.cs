using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    private AudioSource aSource;
    private float lastInputTime; 

    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            if (Time.time - lastInputTime > 0.2f) {
                Shoot();
                lastInputTime = Time.time;
            }
        }
    }

    void Shoot() {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        aSource.Play();
    }
}
