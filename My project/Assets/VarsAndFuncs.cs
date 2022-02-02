using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarsAndFuncs : MonoBehaviour
{
    int myInt = 5;
    // Start is called before the first frame update
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log (myInt);
    }

    // Update is called once per frame
    int MultiplyByTwo (int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
