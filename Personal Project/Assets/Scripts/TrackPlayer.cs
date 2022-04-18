using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPlayer : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody enemyRb;
    private GameObject player;
    private GameObject enemy;

    Quaternion pos = Quaternion.Euler(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        enemy = GameObject.Find("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(moveDirection * speed);
    }
}
