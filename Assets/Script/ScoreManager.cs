using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instace;
    public TMP_Text scoreText;
    public TMP_Text highScoreText;



     int score = 0;
     int highscore = 0;

    private void Awake()
    {
        instace = this;
    }

    private void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore",0);
        scoreText.text = score.ToString() + " Points";
        highScoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    public void AddPoint()
    {
        score +=1;
        scoreText.text = score.ToString() + " Points";
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);       
    }
}
