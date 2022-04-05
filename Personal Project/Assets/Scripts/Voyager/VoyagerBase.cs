using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoyagerBase : MonoBehaviour
{
    private Rigidbody playerRb; //Gets players rigidbody 
    private PlayerStats playerStatsScript;  //Gets base player stats.
    private VoyagerAttack voyagerAttackScript;
    private VoyagerAttack voyagerControlScript;

    // Start is called before the first frame update
    void Start()
    {
        // initialize Voyager Stats 
        playerStatsScript = GameObject.Find("Player").GetComponent<PlayerStats>();

        playerStatsScript.totalHealth *= 1.15f; //Health is 115% of base player heatlh
        playerStatsScript.currentHealth *= 1.15f;
        playerStatsScript.speed +=1.15f;
        playerStatsScript.jumpHeight *= 1.0f;
        playerStatsScript.sprintSpeed *= 1.1f;
        playerStatsScript.primaryAttackDamage *= 1.5f;
        playerStatsScript.specialAttackDamage *= 3.0f;
        playerStatsScript.jumpCount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
