using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayItem : MonoBehaviour
{

    public Item item; // get a reference for an item.

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(item.name);
    }


}
