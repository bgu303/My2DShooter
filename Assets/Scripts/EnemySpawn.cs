using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject fastEnemyPrefab;
    public GameObject tankEnemyPrefab;
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
            int randomEnemySelector = Random.Range(1, 11);

            if (randomEnemySelector <= 5)
            {
                Instantiate(fastEnemyPrefab, spawnPoints[randomSpawn].position, Quaternion.identity);
            }
            else if (randomEnemySelector <= 9)
            {

                Instantiate(enemyPrefab, spawnPoints[randomSpawn].position, Quaternion.identity);
            }
            else {
                Instantiate(tankEnemyPrefab, spawnPoints[randomSpawn].position, Quaternion.identity);
            }
            yield return new WaitForSeconds(1.1f);
        }
    }
}
