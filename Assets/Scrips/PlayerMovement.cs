using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    void Update()
    {
        Vector3 movePos = transform.position;

        if (Input.GetKey("w"))
        {
            movePos.y += speed * Time.deltaTime;
        }

        if (Input.GetKey("s"))
        {
            movePos.y -= speed * Time.deltaTime;
        }
        
        if (Input.GetKey("a"))
        {
            movePos.x -= speed * Time.deltaTime;
        }
        
        if (Input.GetKey("d"))
        {
            movePos.x += speed * Time.deltaTime;
        }
        
        transform.position = movePos;
    }
}
