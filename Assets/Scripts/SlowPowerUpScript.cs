using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowPowerUpScript : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DeleteObjectAfterDelay());
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0.5f;
            Invoke("ResetTimeScale", 5);
            gameObject.SetActive(false);
            Destroy(gameObject, 5.1f);
        }
    }

    void ResetTimeScale()
    {
        Time.timeScale = 1.0f;
    }

    IEnumerator DeleteObjectAfterDelay()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
