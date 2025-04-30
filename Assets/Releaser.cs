using UnityEngine;

public class release : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Mover>().enabled = false;
            rb.constraints = RigidbodyConstraints2D.None;
            rb.linearVelocity = Vector2.zero; // Stop previous movement immediately
        }
    }
}
