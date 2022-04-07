using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public float lookSpeed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Period)) {
            transform.Rotate(Vector3.up, Time.deltaTime * lookSpeed); 
        } else if (Input.GetKey(KeyCode.Comma)) {
            transform.Rotate(-Vector3.up, Time.deltaTime * lookSpeed); 
        }

    }
}
