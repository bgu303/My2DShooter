using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1WeaponScript : MonoBehaviour
{
    public GameObject enemyBulletPrefab;
    public Transform[] firePoint;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    
    void Update()
    {

    }

    IEnumerator SpawnEnemy() {
        while (true) {
            float waitTime = Random.Range(0.3f, 2.0f);
            Instantiate(enemyBulletPrefab, firePoint[0].position, firePoint[0].rotation);
            Instantiate(enemyBulletPrefab, firePoint[1].position, firePoint[1].rotation);
            Instantiate(enemyBulletPrefab, firePoint[2].position, firePoint[2].rotation);
            Instantiate(enemyBulletPrefab, firePoint[3].position, firePoint[3].rotation);
            Instantiate(enemyBulletPrefab, firePoint[4].position, firePoint[4].rotation);
            yield return new WaitForSeconds(waitTime);
        }
    }
}
