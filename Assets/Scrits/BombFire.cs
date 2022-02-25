using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ボムの処理
/// </summary>
public class BombFire : MonoBehaviour
{
    private bool isStandby;

    void Start()
    {
        isStandby = false;
    }

    void FixedUpdate()
    {
        StartCoroutine("UseBomb");
    }

    /// <summary>
    /// ボムを使用した時のメソッド
    /// </summary>
    IEnumerator UseBomb()
    {
        if (Input.GetKeyDown(KeyCode.X) && !isStandby)
        {
            GameObject[] bullets = GameObject.FindGameObjectsWithTag("EnemyBullet");

            foreach (GameObject bullet in bullets)
            {
                Destroy(bullet);
            }
            isStandby = true;
            yield return new WaitForSeconds(5);
            isStandby = false;
        }
    }
}
