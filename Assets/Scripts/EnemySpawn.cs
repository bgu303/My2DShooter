using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject fastEnemyPrefab;
    public Transform[] spawnPoints;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            int randomSpawn = Random.Range(0, spawnPoints.Length);
            int randomNumber = Random.Range(0, 2);

            if (randomNumber == 0)
            {
                Instantiate(fastEnemyPrefab, spawnPoints[randomSpawn].position, Quaternion.identity);
            }
            else
            {

                Instantiate(enemyPrefab, spawnPoints[randomSpawn].position, Quaternion.identity);
            }
            yield return new WaitForSeconds(1.1f);
        }
    }
}
