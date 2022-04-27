using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public UnityEvent gameOver;
    private VoyagerBase voyagerBaseScript;
    private PlayerController playerControllerScript;
    private PlayerStats playerStatsScript;
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        voyagerBaseScript = GameObject.Find("Player").GetComponent<VoyagerBase>();
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        playerStatsScript = GameObject.Find("Player").GetComponent<PlayerStats>();
        playerStatsScript.isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        //if player is dead, invoke gameOver();
        // if (!voyagerBaseScript.playerStatsScript.isAlive) {
        //     gameOver.Invoke();
        // }
    }

    public void GameOver()
    {
        Debug.Log("Game has ended");
        // show game over UI?
        canvas.gameObject.SetActive(true);
        // Stop player and enemy movement
        //playerControllerScript.SetActive(false);
    }

    public void RestartGame()
    {
        Debug.Log("restart game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
