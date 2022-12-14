using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawn : MonoBehaviour
{
    public GameObject slowPrefab;
    float posX;
    float posY;

    void Start()
    {
        StartCoroutine(SpawnPowerUp());
    }

    
    IEnumerator SpawnPowerUp() {
        while (true) {
            posX = Random.Range(ScreenBounds.getScreenBounds().x, ScreenBounds.getScreenBounds().x - 30);
            posY = Random.Range(ScreenBounds.getScreenBounds().y, ScreenBounds.getScreenBounds().y - 13);
            Instantiate(slowPrefab, new Vector2(posX, posY), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(60, 75));
        }
    }
}
