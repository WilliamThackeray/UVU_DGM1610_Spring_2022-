using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public float lookInput;
    public float lookRight;
    public float lookLeft;
    public float lookSpeed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // lookInput = Input.GetAxis("Horizontal");
        // transform.Rotate(Vector3.up, lookInput *  Time.deltaTime * lookSpeed);
        if (Input.GetKey(KeyCode.Period)) {
            // lookInput = Input.GetAxis("Horizontal");
            transform.Rotate(Vector3.up, Time.deltaTime * lookSpeed); 
        } else if (Input.GetKey(KeyCode.Comma)) {
            // lookInput = Input.GetAxis("Horizontal");
            transform.Rotate(-Vector3.up, Time.deltaTime * lookSpeed); 
        }

    }
}
