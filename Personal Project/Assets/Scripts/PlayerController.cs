using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float inputH;
    public float inputV;
    public float gravityModifier;
    public bool onGround = true;
    public float range = 100.0f;
    private Rigidbody playerRb;

    private PlayerStats playerStatsScript;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerStatsScript = GameObject.Find("Player").GetComponent<PlayerStats>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moving NWSE.
        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * inputH * playerStatsScript.speed);
        transform.Translate(Vector3.forward * Time.deltaTime * inputV * playerStatsScript.speed);

        // If player moves 100 in any direction, they should stop moving
        if (transform.position.x >= range) {
            transform.position = new Vector3(range, transform.position.y, transform.position.z);
        }
        if (transform.position.x <= -range) {
            transform.position = new Vector3(-range, transform.position.y, transform.position.z);
        }
        if (transform.position.z >= range) {
            transform.position = new Vector3(transform.position.x, transform.position.y, range);
        }
        if (transform.position.z <= -range) {
            transform.position = new Vector3(transform.position.x, transform.position.y, -range);
        }

        // Player Sprint Action 
        if (Input.GetKey(KeyCode.LeftShift)) {
            playerStatsScript.speed = playerStatsScript.sprintSpeed;
        } else {
            playerStatsScript.speed = 10.0f;
        }

        // Player Jump Action
        if (Input.GetKeyDown(KeyCode.Space) && onGround) {
            playerRb.AddForce(Vector3.up * playerStatsScript.jumpHeight, ForceMode.Impulse);
            onGround = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) {
            onGround = true;
        }
    }
}
