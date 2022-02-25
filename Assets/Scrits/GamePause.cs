using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour
{
    private bool pauseGame;

    void Start()
    {
        pauseGame = false;
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape) && !pauseGame)
        {
            Time.timeScale = 0;
            pauseGame = true;
        }
        else if(Input.GetKeyUp(KeyCode.Escape) && pauseGame)
        {
            pauseGame = false;
            Time.timeScale = 1;
        }
    }
}
