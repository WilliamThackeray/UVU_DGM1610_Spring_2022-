using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoyagerAttack : MonoBehaviour
{
    public GameObject daggerPrefab1; 
    private float timer;
    private float shotTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        // Primary Attack 
        if (Input.GetKeyDown(KeyCode.M)) {
            shotTime = Time.deltaTime;
            // instantiate dagger prefabs here
            Instantiate(daggerPrefab1, transform.position, daggerPrefab1.transform.rotation * transform.rotation);
            Instantiate(daggerPrefab1, transform.position + new Vector3(0.15f, 0, 0), daggerPrefab1.transform.rotation * transform.rotation);
            Instantiate(daggerPrefab1, transform.position + new Vector3(0.3f, 0, 0), daggerPrefab1.transform.rotation * transform.rotation);
            Instantiate(daggerPrefab1, transform.position - new Vector3(0.15f, 0, 0), daggerPrefab1.transform.rotation * transform.rotation);
            Instantiate(daggerPrefab1, transform.position - new Vector3(0.3f, 0, 0), daggerPrefab1.transform.rotation * transform.rotation);
        }
        if ((timer > shotTime + 2) && (shotTime != 0)) {
            Debug.Log("Shot time is less than the timer");
            Destroy(daggerPrefab1);
            shotTime = 0;
        }
    }
}
