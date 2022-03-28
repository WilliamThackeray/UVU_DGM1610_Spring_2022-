using System.Collections.Specialized;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 yOffset = new Vector3 (0, 9, 0);
    // private Quaternion rotateOffset = Quaternion.Euler(0, 90, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + yOffset;
        // transform.rotation = player.transform.rotation + rotateOffset;
    }
}
