using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    public int pHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to the Arena");
        Debug.Log("You are on spikes.");
        while (pHealth > 0) {
            pHealth -= 5;
            Debug.Log("Your healh is at: " + pHealth);
        }
        Debug.Log("You did not move off the spikes. You have died.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
