using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 敵オブジェクトの消去処理
/// </summary>
public class EnemyDestroy : MonoBehaviour
{
    /// <summary>
    /// プレイヤーの弾が着弾時消去
    /// </summary>
    public void DestroyEnemyObject()
    {
        Destroy(this.gameObject);
    }
}
