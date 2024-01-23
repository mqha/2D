using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviourSingletonPersistent<ScoreManager>
{
    public TMP_Text scoreText;
    public TMP_Text highScoreText;

    private int score = 0;
    private int highscore = 0;

    private void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        UpdateUI();
    }

    private void UpdateUI()
    {
        scoreText.text = "Score: " + score.ToString();
        highScoreText.text = "Highscore: " + highscore.ToString();
    }

    public void AddPoint()
    {
        score += 1;
        if (highscore < score)
        {
            highscore = score;
            PlayerPrefs.SetInt("highscore", score);
        }
        UpdateUI();
    }

    public int GetScore()
    {
        return score;
    }



}
