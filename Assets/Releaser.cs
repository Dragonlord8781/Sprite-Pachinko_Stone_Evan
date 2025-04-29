using UnityEngine;

public class release : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Mover>().enabled = false; 
        }
    }
}
