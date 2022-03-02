using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoopsWithArrays : MonoBehaviour
{
    public int pHealth = 100;
    public string[] items = {"Steel Helmet", "Sword", "Fire resistance potion", "Iron Pants", "Leather Boots", "bread"};
    public bool hasFireResist = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Health is: " + pHealth);
        foreach (string item in items) {
            if (item.Contains("Steel")) {
                pHealth += 20;
            } else if (item.Contains("Iron")) {
                pHealth += 10;
            } else if (item.Contains("Leather")) {
                pHealth += 5;
            }
        }

        Debug.Log("Health is now: "+ pHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
