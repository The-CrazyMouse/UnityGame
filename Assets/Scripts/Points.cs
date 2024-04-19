using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Points : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;

    public void AddPoint()
    {
        score++;
        Debug.Log("score: " + score);
    }

    public void LosePoint()
    {
        score--;
        Debug.Log("score: " + score);
    }

    public int getScore()
    {
        return score;
    }
    private void Update()
    {
        scoreText.text = score.ToString("0");
        
    }
}
