using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text scoreText;

    public void Setup()
    {  
        GameObject points = GameObject.Find("ScoreOnScreen");
        int score = points.GetComponent<Points>().getScore();
        gameObject.SetActive(true);
        scoreText.text = "Score: " + score;
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("Level1");
    }
    public void MMButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
