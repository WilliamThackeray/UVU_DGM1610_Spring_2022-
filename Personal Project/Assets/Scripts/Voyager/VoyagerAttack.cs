using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoyagerAttack : MonoBehaviour
{
    public GameObject daggerPrefab1; 
    private float timer;
    private float shotTime;
    Quaternion posRotation1 = Quaternion.Euler(0, 15, 0);
    Quaternion negRotation1 = Quaternion.Euler(0, -15, 0);
    Quaternion posRotation2 = Quaternion.Euler(0, 30, 0);
    Quaternion negRotation2 = Quaternion.Euler(0, -30, 0);

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Primary Attack 
        if (Input.GetKeyDown(KeyCode.M)) {
            shotTime = Time.deltaTime;
            // instantiate dagger prefabs here
            Instantiate(daggerPrefab1, transform.position, daggerPrefab1.transform.rotation * transform.rotation);
            Instantiate(daggerPrefab1, transform.position, daggerPrefab1.transform.rotation * transform.rotation * posRotation1);
            Instantiate(daggerPrefab1, transform.position, daggerPrefab1.transform.rotation * transform.rotation * posRotation2);
            Instantiate(daggerPrefab1, transform.position, daggerPrefab1.transform.rotation * transform.rotation * negRotation1);
            Instantiate(daggerPrefab1, transform.position, daggerPrefab1.transform.rotation * transform.rotation * negRotation2);
        }

    }
}
