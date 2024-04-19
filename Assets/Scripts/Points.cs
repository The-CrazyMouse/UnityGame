using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public int score = 0;

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
}
