using UnityEngine;

public class AddCoins : MonoBehaviour
{

    //when triggered, add point
    private void OnTriggerEnter2D(Collider2D other)
    {
        ScoreManager.instance.AddPoint();
    }
}
