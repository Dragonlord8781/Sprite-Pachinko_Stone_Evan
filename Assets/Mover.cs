using UnityEngine;

public class Mover : MonoBehaviour
{
    public float time;
    public float minX;
    public float maxX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // generate a random x position within the specified range
        float randomX = Random.Range(minX, maxX);

        // set the object's new position, keeping the orginial y and z values 
        transform.position = new Vector3(randomX, transform.position.y, transform.position.z);      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
