using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public static int MaxScore = 0;
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject gameStartGame;
    public AudioSource adScoreSound;
    public AudioSource gameOverSound;
    public bool isGameStarted = true;

    [ContextMenu("Increase Score")]
    public void addScore(int addScore)
    {
        playerScore += addScore;
        scoreText.text = playerScore.ToString();
        adScoreSound.Play();
    }

    //public void newGame()
    //{
    //    isGameStarted = true;
    //    gameStartGame.SetActive(false);
    //}

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverSound.Play();
        gameOverScreen.SetActive(true);
        if (MaxScore < playerScore)
        {
            MaxScore = playerScore;
        }
    }
}
