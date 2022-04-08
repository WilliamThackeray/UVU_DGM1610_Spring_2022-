using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject player;
    public GameObject enemyPrefab;

    private float curPos;
    private int enemiesToSpawn = 2;
    public float spawnRange = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        StartCoroutine(EnemySpawnsRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator EnemySpawnsRoutine () 
    {
        yield return new WaitForSeconds(8);
        for (int i = 0; i < enemiesToSpawn; i++) {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation); 
        }
        StartCoroutine(EnemySpawnsRoutine());
    }
    public Vector3 GenerateSpawnPosition() 
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randPos = new Vector3(spawnPosX,0,spawnPosZ);
        return randPos;
    }
} 
