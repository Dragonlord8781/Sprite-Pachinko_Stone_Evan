using UnityEngine;

public class AddCoins : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        ScoreManager.instance.AddPoint();
    }
}
