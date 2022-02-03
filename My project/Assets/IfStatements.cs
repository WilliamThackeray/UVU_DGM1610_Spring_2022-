using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemp = 85.0f;
    float hotLimitTemp = 70.0f;
    float coldLimitTemp = 40.0f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();
    }

    void TemperatureTest ()
    {
        if(coffeeTemp > hotLimitTemp)
        {
            print("Cofee is too hot.");
        }
        else if(coffeeTemp < coldLimitTemp)
        {
            print("Coffee is too cold.");
        }
        else
        {
            print("Coffee is just right.");
        }
    }
}
