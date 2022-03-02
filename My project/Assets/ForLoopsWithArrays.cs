using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopsWithArrays : MonoBehaviour
{
    public int pHealth = 100;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to the Arena");
        Debug.Log("You have been lit on fire.");
        for (int i = 0; i < 15; i++) {
            pHealth -= 1;
            Debug.Log("Your Health: "+ pHealth);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
