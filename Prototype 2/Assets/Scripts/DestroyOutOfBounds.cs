using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // top boundaries
    private float topBound = 30.0f;
    // bottom boundries
    private float botBound = -15.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound) // Destroy objects shot by the player
        {
            Destroy(gameObject);
        } 
        else if (transform.position.z < botBound) // Destroy animals that run past the player
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }
        
    }
}
