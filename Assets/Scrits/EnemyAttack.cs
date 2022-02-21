using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 敵の攻撃処理
/// </summary>
public class EnemyAttack : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyBullet;

    void Start()
    {
        StartCoroutine("EnemyAtacckInterval");
        GameObject obj = Instantiate(enemyBullet, Vector3.zero, Quaternion.identity);
    }

    /// <summary>
    /// 弾の打つ間隔
    /// </summary>
    IEnumerator EnemyAtacckInterval()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
        }
    }
}