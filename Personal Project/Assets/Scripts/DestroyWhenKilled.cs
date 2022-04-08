using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenKilled : MonoBehaviour
{
    private PlayerStats playerStatsScript;  //Gets base player stats.
    public int health = 100;
    // Start is called before the first frame update
    void Start()
    {
        playerStatsScript = GameObject.Find("Player").GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Dagger") 
        {
            Destroy(other.gameObject);
            health -= 10;
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        } 
        if (other.gameObject.tag == "Player") {
            playerStatsScript.currentHealth -= 5;
        }
        if (playerStatsScript.currentHealth <= 0)
        {
            Destroy(other.gameObject);
        }
        
    }
}
