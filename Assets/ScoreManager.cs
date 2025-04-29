using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    //supposed to allow other classes to call an instance of ScoreManager
    public static ScoreManager instance;

    //create properties for text boxes to connect to
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    //creates public score and highscore
    public int score;
    public int highscore;
    
    //when instance is called do this, I think
    private void Awake()
    {
       instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //starts with blank slate
        scoreText.text = "Current: " + score.ToString() + " GP";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    //adds point when called
    public void AddPoint()
    {
        score++;
        scoreText.text = "Current: " + score.ToString() + " GP";
        Debug.Log("add 1 GP");
    }
    
    //changes highscore if score is greater than highscore, either way writes score
    public void changeHighscore()
    {
        if (score > highscore)
        {
            highscore = score;
        }
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
        Debug.Log("highscore changed");
    }

    //clears the score when called 
    public void clearScore()
    {
        score = 0;
        scoreText.text = "Current: " + score.ToString() + " GP";
        Debug.Log("score cleared");
    }
}
