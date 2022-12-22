using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float scoreMultiplayer;

    public const string HighScoreKey = "HighScore";

    private float score;

    void Start()
    {
        
    }

    void Update()
    {
        score += Time.deltaTime * scoreMultiplayer;

        scoreText.text = Mathf.FloorToInt(score).ToString();

    }

    private void OnDestroy()
    {
        int currentHighscore = PlayerPrefs.GetInt(HighScoreKey, 0);

        if(score>currentHighscore)
        {
            PlayerPrefs.SetInt(HighScoreKey, Mathf.FloorToInt(score));
        }
    }
}
