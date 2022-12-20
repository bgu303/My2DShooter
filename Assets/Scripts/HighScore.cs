using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    public int highScore;
    public TextMeshProUGUI scoreText;

    void Start()
    {

    }

    void Update()
    {
        scoreText.text = "Score: " + highScore;
    }

    public int AddPoints(int points)
    {
        return highScore += points;
    }
}