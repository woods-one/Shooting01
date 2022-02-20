using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCotroller : MonoBehaviour
{

    [SerializeField]
    private float playerSpeed;


    void  FixedUpdate()
    {
        MovePlayer();
    }



    void MovePlayer()
    {
        Vector3 playerPos = transform.position;
        
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            playerPos.y += playerSpeed * Time.deltaTime;
        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            playerPos.y -= playerSpeed * Time.deltaTime;
        }

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            playerPos.x += playerSpeed * Time.deltaTime;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            playerPos.x -= playerSpeed * Time.deltaTime;
        }

        transform.position = playerPos;
    }
}
