using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 敵の弾を消す処理
/// </summary>
public class EnemyBulletDestroy : MonoBehaviour
{
    /// <summary>
    /// 衝突時処理
    /// </summary>
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(this.gameObject); 
        }
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            other.gameObject.GetComponent<PlayerDestroy>().DestroyPlayerObject();
            Time.timeScale = 0;
        }
    }
}
