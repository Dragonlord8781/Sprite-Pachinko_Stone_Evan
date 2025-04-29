using JetBrains.Annotations;
using UnityEngine;

public class GetScrewed : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ScoreManager.instance.changeHighscore();
        ScoreManager.instance.clearScore();
    }
}
