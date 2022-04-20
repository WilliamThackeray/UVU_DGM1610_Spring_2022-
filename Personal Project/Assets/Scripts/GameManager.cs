using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public UnityEvent gameOver;
    private VoyagerBase voyagerBaseScript;

    // Start is called before the first frame update
    void Start()
    {
        voyagerBaseScript = GameObject.Find("Player").GetComponent<VoyagerBase>();
    }

    // Update is called once per frame
    void Update()
    {
        //if player is dead, invoke gameOver();
        if (!voyagerBaseScript.playerStatsScript.isAlive) {
            gameOver.Invoke();
        }
    }

    public void GameOver()
    {
        Debug.Log("Game has ended");
        // show game over UI?
        // Stop player and enemy movement
    }
}
