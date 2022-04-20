using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public float lookSpeed = 100.0f;
    private PlayerStats playerStatsScript;  //Gets base player stats.

    // Start is called before the first frame update
    void Start()
    {
        playerStatsScript = GameObject.Find("Player").GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerStatsScript.isAlive) {
            if (Input.GetKey(KeyCode.Period)) {
                transform.Rotate(Vector3.up, Time.deltaTime * lookSpeed); 
            } else if (Input.GetKey(KeyCode.Comma)) {
                transform.Rotate(-Vector3.up, Time.deltaTime * lookSpeed); 
            }
        }

    }
}
