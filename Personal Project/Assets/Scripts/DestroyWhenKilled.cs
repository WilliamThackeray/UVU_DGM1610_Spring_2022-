using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenKilled : MonoBehaviour
{
    private PlayerStats playerStatsScript;  //Gets base player stats.
    private GameManager gameManagerScript;
    public int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        playerStatsScript = GameObject.Find("Player").GetComponent<PlayerStats>();
        gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // When an attack hits an enemy, destroy and cause damage
    private void OnCollisionEnter(Collision other) {
        if (!playerStatsScript.isAlive) {
            gameManagerScript.gameOver.Invoke();
        }
        if (other.gameObject.tag == "Dagger") 
        {
            Destroy(other.gameObject);
            health -= 10;
            StartCoroutine(DamageOverTime());
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        } 
        if (other.gameObject.tag == "Player") {
            playerStatsScript.currentHealth -= 5;
        }
        
    }

    // IEnumerator for the poison damage on the enemy 
    IEnumerator DamageOverTime () {
        for (int i = 0; i < 5; i++) {
            yield return new WaitForSeconds(1);
            health -= 3;
        }

    }
}
