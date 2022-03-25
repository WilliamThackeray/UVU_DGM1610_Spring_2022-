using System.Collections.Specialized;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float baseSpeed = 10.0f;
    public float inputH;
    public float inputV;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * inputH * baseSpeed);
        transform.Translate(Vector3.forward * Time.deltaTime * inputV * baseSpeed);
    }
}
