using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameEnded;

    [SerializeField] GameObject _gameOverUI;
    // Update is called once per frame

    private void Start()
    {
        gameEnded = false;
    }
    void Update()
    {
        if (gameEnded)
        {
            return;
        }
        if(PlayerStats.playerHP <= 0)
        {
            EndGame();
        }
            
    }
    private void EndGame()
    {
        gameEnded = true;
        _gameOverUI.SetActive(true);
        Time.timeScale = 0; 
    }
}
