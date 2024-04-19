using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float restartTimer = 2f;
    public GameOverScreen gameOverScreen;
    public int score;
    public WaveSpawner waveSpawner;
    
    public void GameOver()
    {
        GameObject points = GameObject.Find("ScoreOnScreen");
        points.GetComponent<Points>().AddPoint();
        Debug.Log("entrou");
        gameOverScreen.Setup();
        waveSpawner.State= WaveSpawner.SpawnState.GAMEOVER;
        Invoke("Restart", restartTimer);
    }

    public void Restart()
    {
        Debug.Log("restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
