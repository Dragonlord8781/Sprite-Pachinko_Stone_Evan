using JetBrains.Annotations;
using UnityEngine;

public class GetScrewed : MonoBehaviour
{
    //when triggered, change highscore and cleares score
    private void OnTriggerEnter2D(Collider2D other)
    {
        ScoreManager.instance.changeHighscore();
        ScoreManager.instance.clearScore();
    }
}
