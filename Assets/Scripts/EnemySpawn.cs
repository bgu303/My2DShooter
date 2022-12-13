using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spawnPoints;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy() {
        while (true) {
            int randomSpawn = Random.Range(0, spawnPoints.Length);
            Instantiate(enemyPrefab, spawnPoints[randomSpawn].position, Quaternion.identity);
            yield return new WaitForSeconds(0.4f);
        }
    }
}
