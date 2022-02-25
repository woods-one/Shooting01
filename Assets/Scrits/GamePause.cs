using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ゲームのポーズ処理クラス
/// </summary>
public class GamePause : MonoBehaviour
{
    private bool pauseGame;

    [SerializeField]
    private GameObject gamePauseObeject;

    void Start()
    {
        gamePauseObeject.SetActive(false);
        pauseGame = false;
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape) && !pauseGame)
        {
            Time.timeScale = 0;
            gamePauseObeject.SetActive(true);
            pauseGame = true;
        }
        else if(Input.GetKeyUp(KeyCode.Escape) && pauseGame)
        {

            Time.timeScale = 1;
            gamePauseObeject.SetActive(false);
            pauseGame = false;
        }
    }
}
