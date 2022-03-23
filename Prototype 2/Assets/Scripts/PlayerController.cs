using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput; // Grabs the users left to right positioning
    public float speed = 10.0f; // used for player speed
    public float xrange = 10.0f; // used for the player left and right side boundaries
    public GameObject projectilePrefab1;
    public GameObject projectilePrefab2;
    public GameObject projectilePrefab3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Tests to see if the player moves too far in the negative x direction
        if (transform.position.x < -xrange) {
            transform.position= new Vector3(-xrange, transform.position.y, transform.position.z);
        }
        // Tests to see if the player moves too far in the positive x direction
        if (transform.position.x > xrange) {
            transform.position= new Vector3(xrange, transform.position.y, transform.position.z);
        }
        // Moves the player
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space)) {
            // launch projectiles
            Instantiate(projectilePrefab1, transform.position, projectilePrefab1.transform.rotation);
            Instantiate(projectilePrefab2, transform.position + new Vector3(1.3f, 0, 0), projectilePrefab2.transform.rotation);
            Instantiate(projectilePrefab3, transform.position - new Vector3(1.3f, 0, 0), projectilePrefab3.transform.rotation);
        }
    }
}
