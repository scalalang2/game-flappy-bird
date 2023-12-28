using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text text;
    public GameObject gameOverScreen;

    // 이거 너무 개꿀 기능이잖아?? 
    // 오나전 handy 해 ~~
    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore++;
        text.text = playerScore.ToString();
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
