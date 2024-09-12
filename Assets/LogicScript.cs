using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public GameObject gameOverScreen;
    public Text scoreText;
    [ContextMenu("Increase Score")]
    public void addScore(){
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }
    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver(){
        gameOverScreen.SetActive(true);
    }
}
