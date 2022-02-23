using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤーオブジェクトの消去処理
/// </summary>
public class PlayerDestroy : MonoBehaviour
{
    /// <summary>
    /// 敵の弾が着弾時消去
    /// </summary>
    public void DestroyPlayerObject()
    {
        Destroy(this.gameObject);
    }
}
