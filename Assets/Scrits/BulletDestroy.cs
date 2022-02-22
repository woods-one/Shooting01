using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 敵の弾を消す処理
/// </summary>
public class BulletDestroy : MonoBehaviour
{
    /// <summary>
    /// 衝突時処理
    /// </summary>
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(this.gameObject);
            Debug.Log("Wall");
        }
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            Debug.Log("Player");
        }
    }
}
