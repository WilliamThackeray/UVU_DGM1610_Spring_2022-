// MAYBE CONVERT THIS FILE INTO A SCRIPTABLE OBJECT FOR EACH TYPE OF CHAMPION //

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float totalHealth;
    public float currentHealth;
    public float speed;
    public float jumpHeight;
    public float sprintSpeed;
    public float primaryAttackDamage;
    public float specialAttackDamage;
    public int playerLevel;    
    public int jumpCount = 1;
    public bool isAlive;

    // Start is called before the first frame update
    void Start()
    {
        totalHealth = 100.0f;
        currentHealth = 100.0f;
        speed = 10.0f;
        jumpHeight = 500.0f;
        sprintSpeed = speed * 0.5f;
        primaryAttackDamage = 10.0f;
        specialAttackDamage = 20.0f;
        playerLevel = 1;
        jumpCount = 1;
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
