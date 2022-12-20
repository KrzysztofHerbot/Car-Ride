using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float scoreMultiplayer;

    private float score;

    void Start()
    {
        
    }

    void Update()
    {
        score += Time.deltaTime * scoreMultiplayer;

        scoreText.text = Mathf.FloorToInt(score).ToString();

    }
}
