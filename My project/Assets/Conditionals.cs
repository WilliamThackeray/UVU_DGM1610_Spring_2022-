using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
  
class Conditionals {
  
    void Start()
    {
      Dictionary<string, int> healthItems = new Dictionary<string, int>();
      Dictionary<string, int> attackItems = new Dictionary<string, int>();
      Dictionary<string, int> enemies = new Dictionary<string, int>();

      healthItems.Add("helmet", 10);
      healthItems.Add("chestplate", 20);
      healthItems.Add("pants", 15);
      healthItems.Add("boots", 5);

      attackItems.Add("sword", 10);
      attackItems.Add("knife", 1);
      attackItems.Add("bow", 6);
      attackItems.Add("spear", 12);

      enemies.Add("golem", 200);
      enemies.Add("rat", 5);
      enemies.Add("zombie", 50);
      enemies.Add("ghoul", 65);
      
      
      var playerHealth = 100;
      var enemyHealth = enemies["zombie"];
      
      while (playerHealth > 0 && enemyHealth > 0) {
        // take input here
        enemyHealth -= 10;
      }
      if (playerHealth <= 0) {
        Debug.Log("You have died.");
      } else if (enemyHealth <= 0) {
        Debug.Log("Enemy has been killed.");
      }
    }

    void Update() {

    }
}

