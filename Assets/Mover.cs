using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 2f;
    public bool movRight = false;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
    }

    void OnEnable()
    {
        if (rb == null)
            rb = GetComponent<Rigidbody2D>();

        // Reset physics when Mover is re-enabled
        rb.linearVelocity = Vector2.zero;
        rb.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
    }

    void Update()
    {
        float direction = movRight ? 1f : -1f;
        transform.Translate(direction * speed * Time.deltaTime, 0f, 0f, Space.World);

        if (transform.position.x > 8f)
        {
            movRight = false;
        }
        else if (transform.position.x < -8f)
        {
            movRight = true;
        }
    }
}
