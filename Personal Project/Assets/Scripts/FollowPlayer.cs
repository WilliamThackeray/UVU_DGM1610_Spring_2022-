using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 yOffset;
    public float damping = 100;
    // private Quaternion rotateOffset = Quaternion.Euler(75, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        yOffset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float currentAngle = transform.eulerAngles.y;
        float ang = player.transform.eulerAngles.y;
        float angle = Mathf.LerpAngle(currentAngle, ang, Time.deltaTime * damping);
        Quaternion rotation = Quaternion.Euler(0, angle, 0);

        transform.position = player.transform.position + (rotation * yOffset);
         
        transform.LookAt(player.transform);
    }
}
