using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombFire : MonoBehaviour
{
    private bool isStandby;

    void Start()
    {
        isStandby = false;
    }

    void FixedUpdate()
    {
        StartCoroutine("UseBomb");
    }

    IEnumerator UseBomb()
    {
        if (Input.GetKeyDown(KeyCode.X) && !isStandby)
        {
            GameObject[] bullets = GameObject.FindGameObjectsWithTag("EnemyBullet");

            foreach (GameObject bullet in bullets)
            {
                Destroy(bullet);
            }
            isStandby = true;
            yield return new WaitForSeconds(5);
            isStandby = false;
        }
    }
}
