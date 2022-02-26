using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤーのショット処理
/// </summary>
public class PlayerShot : MonoBehaviour
{
    [SerializeField]
    private float bulletSpeed;
    [SerializeField]
    private GameObject playerBullet;

    [SerializeField]
    private float shotIntervalTime;


    void Start()
    {
        StartCoroutine("PlayerShotInterval");
    }

    /// <summary>
    /// プレイヤーの弾を打つ間隔
    /// </summary>
    IEnumerator PlayerShotInterval()
    {
        while (true)
        {
            yield return new WaitForSeconds(shotIntervalTime);
            if (Input.GetKey(KeyCode.Z))
            {
                var playerShot = Instantiate(playerBullet, transform.position, Quaternion.identity);
                playerShot.GetComponent<Rigidbody2D>().velocity = transform.up * bulletSpeed;
            }
        }
    }
}
