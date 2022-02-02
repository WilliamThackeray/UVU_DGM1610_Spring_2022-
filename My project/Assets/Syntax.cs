using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syntax : MonoBehaviour
{

    void Start()
    {
        // this line is to tell me the x position of my object

        /* Hi there!
        * This is two lines! 
        * */

        Debug.Log(transform.position.x);

        if(transform.position.x);
        {
            Debug.Log ("I'm about to hit the ground!");
        }
    }
}
