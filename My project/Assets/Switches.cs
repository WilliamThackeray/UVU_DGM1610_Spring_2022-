using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    public double critChance = .2;
    public int attackDamage = 10;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (critChance) {
            case 1:
                Debug.Log("Critical Damage: " + (attackDamage * critChance));
                Debug.Log("Attack Damage: " + (attackDamage + (attackDamage*critChance))*10);
                break;
            case 0.9:
                Debug.Log("Critical Damage: " + (attackDamage * critChance));
                Debug.Log("Attack Damage: " + (attackDamage + (attackDamage*critChance))*9);
                break;
            case 0.8:
                Debug.Log("Critical Damage: " + (attackDamage * critChance));
                Debug.Log("Attack Damage: " + (attackDamage + (attackDamage*critChance))*8);
                break;
            case 0.7:
                Debug.Log("Critical Damage: " + (attackDamage * critChance));
                Debug.Log("Attack Damage: " + (attackDamage + (attackDamage*critChance))*7);
                break;
            case 0.6:
                Debug.Log("Critical Damage: " + (attackDamage * critChance));
                Debug.Log("Attack Damage: " + (attackDamage + (attackDamage*critChance))*6);
                break;
            case 0.5:
                Debug.Log("Critical Damage: " + (attackDamage * critChance));
                Debug.Log("Attack Damage: " + (attackDamage + (attackDamage*critChance))*5);
                break;
            case 0.4:
                Debug.Log("Critical Damage: " + (attackDamage * critChance));
                Debug.Log("Attack Damage: " + (attackDamage + (attackDamage*critChance))*4);
                break;
            case 0.3:
                Debug.Log("Critical Damage: " + (attackDamage * critChance));
                Debug.Log("Attack Damage: " + (attackDamage + (attackDamage*critChance))*3);
                break;
            case 0.2:
                Debug.Log("Critical Damage: " + (attackDamage * critChance));
                Debug.Log("Attack Damage: " + (attackDamage + (attackDamage*critChance))*2);
                break;
            case 0.1:
                Debug.Log("Critical Damage: " + (attackDamage + (attackDamage*critChance)));
                break;
            case 0.0:
                Debug.Log("Critical Damage: " + (attackDamage + (attackDamage*critChance)));
                break;
            default:
                Debug.Log("Critical Damage: " + attackDamage);
                break;
            
        }
    }

    void OnMouseDown() {
        Debug.Log("Attack Damage was: " + critChance);
    }
}
