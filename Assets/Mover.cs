using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;
    public bool movRight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(7, 5, transform.position.z);
        movRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(movRight)
        {
            transform.Translate(speed * Time.deltaTime, 0f, 0f, Space.World);
        }
        else
        {
            transform.Translate(-speed * Time.deltaTime, 0f, 0f, Space.World);
        }


        if(transform.position.x > 8)
        {
           movRight = false;
        }
        if(transform.position.x < -8)
        {
            movRight = true;
        }
    }
}
