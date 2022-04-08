using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenKilled : MonoBehaviour
{
    public int health = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Dagger") 
        {
            Destroy(other.gameObject);
            health -= 10;
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        } 
        
    }
}
