using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyBullet;

    void Start()
    {
        StartCoroutine("EnemyAtacckInterval");
        GameObject obj = Instantiate(enemyBullet, Vector3.zero, Quaternion.identity);
    }

    void FixedUpdate()
    {

    }

    IEnumerator EnemyAtacckInterval()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
        }
    }
}