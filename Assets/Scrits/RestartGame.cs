using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// ゲームをやり直すクラス
/// </summary>
public class RestartGame : MonoBehaviour
{
    /// <summary>
    /// ボタンが押されたとき、やり直す
    /// </summary>
    public void PushRestartButton()
    {
        SceneManager.LoadScene("Main");
    }
}
