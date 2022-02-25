using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ゲームのポーズ処理クラス
/// </summary>
public class GamePause : MonoBehaviour
{
    private bool isPauseGame;

    [SerializeField]
    private GameObject gamePauseObeject;

    void Start()
    {
        gamePauseObeject.SetActive(false);
        isPauseGame = false;
    }

    void Update()
    {
        ShowGamePause();
    }

    void ShowGamePause()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && !isPauseGame)
        {
            Time.timeScale = 0;
            gamePauseObeject.SetActive(true);
            isPauseGame = true;
        }
        else if (Input.GetKeyUp(KeyCode.Escape) && isPauseGame)
        {

            Time.timeScale = 1;
            gamePauseObeject.SetActive(false);
            isPauseGame = false;
        }
    }
}
