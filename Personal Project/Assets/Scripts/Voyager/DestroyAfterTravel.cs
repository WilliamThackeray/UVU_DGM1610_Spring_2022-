using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTravel : MonoBehaviour
{
    private float curPos;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        curPos = Vector3.Distance(player.transform.position, transform.position);
        if (curPos > 10) {
            Destroy(gameObject);
        }
    }
}
