using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ゲームマネージャークラス
/// ここでゲーム開始時の処理を呼んだりする
/// </summary>
public class GameManager : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
    }
}
