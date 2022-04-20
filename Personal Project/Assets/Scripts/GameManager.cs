using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public UnityEvent gameOver;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if player is dead, invoke gameOver();
        gameOver.Invoke();
    }

    public void GameOver()
    {
        // gameOver.Invoke();
        Debug.Log("Game has ended");
    }
}
