using UnityEngine;

public class teleporter : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject objectToMove;
    private Mover moverScript;
    private void Start()
    {
        objectToMove = GameObject.Find("Coin");
        moverScript = objectToMove.GetComponent<Mover>();
        rb = objectToMove.GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        moverScript.movRight = false;
        rb.linearVelocity = Vector2.zero;
        rb.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
        objectToMove.transform.position = new Vector3(7, 5, objectToMove.transform.position.z);
        moverScript.enabled = true;
    }

}
