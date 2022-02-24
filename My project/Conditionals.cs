using System;
using System.Collection.Generics; 
  
class Conditionals {
  
    public static void Main()
    {
      Dictionary healthItems = new Dictionary();
      Dictionary attackItems = new Dictionary();
      Dictionary enemies = new Dictionary();

      healthItems.add("helmet", 10);
      healthItems.add("chestplate", 20);
      healthItems.add("pants", 15);
      healthItems.add("boots", 5);

      attackItems.add("sword", 10);
      attackItems.add("knife", 1);
      attackItems.add("bow", 6);
      attackItems.add("spear", 12);

      enemies.add("golem", 200);
      enemies.add("rat", 5);
      enemies.add("zombie", 50);
      enemies.add("ghoul", 65);
      
      
      var playerHealth = 100;
      var enemyHealth = enemies["zombie"];
      
      while (playerHealth > 0 && enemyHealth > 0) {
        // take input here
        enemyHealth -= 10;
      }
      if (playerHealth <= 0) {
        Console.WriteLine("You have died.");
      } else if (enemyHealth <= 0) {
        Console.WriteLine("Enemy has been killed.");
      }
    }
}

