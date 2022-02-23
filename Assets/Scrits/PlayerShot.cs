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
    void Start()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            var playerShot = Instantiate(playerBullet, transform.position, Quaternion.identity);
            playerShot.GetComponent<Rigidbody2D>().velocity = transform.up.normalized * bulletSpeed;
        }
    }
}
