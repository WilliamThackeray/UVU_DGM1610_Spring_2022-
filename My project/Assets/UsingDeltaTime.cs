using System.Collections;
using UnityEngine;

public class UsingDeltaTime : MonoBehaviour
{
    public float speed = 8f;
    public float countdown = 3.0f;

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if(countdown <= 0.0f)
            light.enabled = true;

        if(Input.GetKey(KeyCode.RightArrow))
            transform.position += new Vector3(speed * Time.delataTime, 0.0f, 0.0f);
    }
}
