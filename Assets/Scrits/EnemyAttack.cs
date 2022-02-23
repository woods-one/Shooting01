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

    [SerializeField]
    private float intervalTime;
    [SerializeField]
    private float bulletSpeed;

    private Vector3 enemyDirection;

    [SerializeField]
    private GameObject enemyObject;

    private GameObject playerObject;

    void Start()
    {

        playerObject = GameObject.Find("Player");
        StartCoroutine("EnemyShotInterval"); 
    }

    void FixedUpdate()
    {
        enemyDirection = (playerObject.transform.position - enemyObject.transform.position);
        enemyObject.transform.rotation = Quaternion.FromToRotation(Vector3.up, enemyDirection);
    }

    /// <summary>
    /// 敵の弾を打つ間隔
    /// </summary>
    IEnumerator EnemyShotInterval()
    {
        while (true)
        { 
            yield return new WaitForSeconds(intervalTime);
            var enemyShot = Instantiate(enemyBullet, transform.position, Quaternion.identity);
            enemyShot.GetComponent<Rigidbody2D>().velocity = transform.up.normalized * bulletSpeed;
        }
    }
}