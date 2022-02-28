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

    [SerializeField]
    float horizontalSpeed;
    [SerializeField]
    float downSpeed;

    bool isRight;

    void Start()
    {
        isRight = true;
        firstpos = this.transform.position;
        sin = 0;
        cos = 0;
    }
    void FixedUpdate()
    {
        sin = Mathf.Sin(Time.time);
        cos = Mathf.Cos(Time.time);
        firstpos.y -= downSpeed;
        if(isRight)
        {
            MoveRight();
        }
        else
        {
            MoveLeft();
        }
        
    }

    void MoveRight()
    {
        firstpos.x += horizontalSpeed;
        this.transform.position = new Vector3(firstpos.x + sin * hoge, firstpos.y + cos * hoge2, 0);
    }

    void MoveLeft()
    {
        firstpos.x -= horizontalSpeed;
        this.transform.position = new Vector3(firstpos.x - sin * hoge, firstpos.y + cos * hoge2, 0);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "RightWall")
        {
            isRight = false;
        }
        if (other.gameObject.name == "LeftWall")
        {
            isRight = true;
        }
    }
}
