using System.Collections;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    private Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<rigidbody>();
    }


    void OnMouseDown()
    {
        rigidbody.AddForce(-transform.forward * 500f);
        rigidbody.useGravity = true;
    }
}
