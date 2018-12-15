using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    
    public float dirX, moveSpeed = 3.0f;
    bool moveRight = true;
    public float firstPositionX;
    public float secondPositonX;

    void Update()
    {
        if (transform.position.x >= secondPositonX)
            moveRight = false;
        if(transform.position.x <= firstPositionX)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
    }
}
