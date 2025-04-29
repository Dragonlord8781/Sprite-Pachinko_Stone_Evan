using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    public int score;
    public int highscore;
    
    
    private void Awake()
    {
       instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = "Current: " + score.ToString() + " GP";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    public void AddPoint()
    {
        score++;
        scoreText.text = "Current: " + score.ToString() + " GP";
    }
    
    public void changeHighscore()
    {
        if (score > highscore)
        {
            highscore = score;
        }
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    public void clearScore()
    {
        score = 0;
        scoreText.text = "Current: " + score.ToString() + " GP";
    }
}
