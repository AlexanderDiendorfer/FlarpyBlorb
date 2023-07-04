using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource scoreSFX;
    public AudioSource dieSFX;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        if (!gameOverScreen.activeSelf)
        {
            Debug.Log("Triggered");
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();
            scoreSFX.Play();
        }

    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        dieSFX.Play();
        gameOverScreen.SetActive(true);
    }
}
