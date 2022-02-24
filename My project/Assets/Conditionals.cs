using System.Collections.Generic;
using System.Collections;
using UnityEngine;
  
public class Conditionals : MonoBehaviour 
{
    public int playerHealth = 100;
    public int enemyHealth = 100;

    private void Awake() 
    {

    }
    void OnMouseDown() 
    {
      Debug.Log("Player health: " + playerHealth);
      Debug.Log("Enemy health: " + enemyHealth);

      if (playerHealth == 0) {
        Debug.Log("Player has been killed");
      } else if (enemyHealth == 0) {
        Debug.Log("Enemy has been killed");
      }
      if (Input.GetKeyDown(KeyCode.Space)) {
        enemyHealth -= 10;
      }
    }
  
}