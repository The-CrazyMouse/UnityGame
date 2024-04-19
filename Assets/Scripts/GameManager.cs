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
    public int score = 0;
    
    public void GameOver()
    {
        Debug.Log("entrou");
        gameOverScreen.Setup(score);
        Invoke("Restart", restartTimer);
    }

    public void Restart()
    {
        Debug.Log("restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
