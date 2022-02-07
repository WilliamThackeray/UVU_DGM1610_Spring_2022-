using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformFunctions : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            TransformFunctions.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            TransformFunctions.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            TransformFunctions.Translate(Vector3.up * -turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            TransformFunctions.Translate(Vector3.up * turnSpeed * Time.deltaTime);
    }
}
