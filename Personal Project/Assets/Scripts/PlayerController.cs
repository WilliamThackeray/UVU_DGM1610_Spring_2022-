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
    public int baseJumps;

    // public GameObject daggerPrefab1; 

    // imports the players stats declared in the PlayerStats Script
    private PlayerStats playerStatsScript;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerStatsScript = GameObject.Find("Player").GetComponent<PlayerStats>();
        baseJumps = playerStatsScript.jumpCount;
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
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            playerStatsScript.speed += playerStatsScript.sprintSpeed;
        } else if (Input.GetKeyUp(KeyCode.LeftShift)) {
            playerStatsScript.speed -= playerStatsScript.sprintSpeed;
        }

            // Player Jump Action
        if (Input.GetKeyDown(KeyCode.Space) && (onGround || playerStatsScript.jumpCount > 0)) {
            playerRb.AddForce(Vector3.up * playerStatsScript.jumpHeight, ForceMode.Impulse);
            onGround = false;
            playerStatsScript.jumpCount -= 1;
        }
        // if (Input.GetKeyDown(KeyCode.M)) {
        //     Instantiate(daggerPrefab1, transform.position, daggerPrefab1.transform.rotation + transform.rotation);
        // }
    }
    private void OnCollisionEnter(Collision collision)
    {
        // onGround is true when the player lands back on the ground
        if (collision.gameObject.CompareTag("Ground")) {
            onGround = true;
            // resets the number of jumps the player gets after they land
            playerStatsScript.jumpCount = baseJumps;
        }
    }
}
