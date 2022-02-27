using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveTest : MonoBehaviour
{
    Vector3 firstpos;
    float sin;
    float cos;
    [SerializeField]
    float hoge;
    [SerializeField]
    float hoge2;

    void Start()
    {
        firstpos = this.transform.position;
    }
    void Update()
    {
        sin = Mathf.Sin(Time.time);
        cos = Mathf.Cos(Time.time);
        this.transform.position = new Vector3(firstpos.x + sin * hoge, firstpos.y + cos * hoge2, 0);
    }
}
