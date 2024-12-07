using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TMP_Text scoreText;
    public int score;

    public void Awake()
    {
        instance = this;
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.SetText(score.ToString());
    }
}
