using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤーの動きの処理
/// </summary>
public class PlayerCotroller : MonoBehaviour
{ 
    [SerializeField]
    private float playerSpeed;

    private float playerSpeedRatio = 1;


    void FixedUpdate()
    {
        MovePlayer();
    }


    /// <summary>
    /// 矢印キーでプレイヤーの上下移動を制御するメソッド
    /// </summary>
    void MovePlayer()
    {
        Vector3 playerPos = transform.position;

        if (Input.GetAxisRaw("Vertical") > 0)
        {
            playerPos.y += playerSpeed * Time.deltaTime * playerSpeedRatio;
        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            playerPos.y -= playerSpeed * Time.deltaTime * playerSpeedRatio;
        }

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            playerPos.x += playerSpeed * Time.deltaTime * playerSpeedRatio;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            playerPos.x -= playerSpeed * Time.deltaTime * playerSpeedRatio;
        }

        transform.position = playerPos;
    }

}
