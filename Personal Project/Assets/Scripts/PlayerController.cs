using System.Collections.Specialized;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float baseSpeed = 10.0f;
    public float forwardInput;
    public float backwardInput;
    public float leftInput;
    public float rightInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            forwardInput = Input.GetAxis("Vertical");
            transform.Translate(Vector3.forward * forwardInput * Time.deltaTime * baseSpeed);
        }
        else if (Input.GetKey(KeyCode.S)) {
            backwardInput = Input.GetAxis("Vertical");
            transform.Translate(Vector3.forward * backwardInput * Time.deltaTime * baseSpeed);
        }
        else if (Input.GetKey(KeyCode.A)) {
            leftInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * leftInput * Time.deltaTime * baseSpeed);
        }
        else if (Input.GetKey(KeyCode.D)) {
            rightInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * rightInput * Time.deltaTime * baseSpeed);
        }
    }
}
