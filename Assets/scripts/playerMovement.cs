using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 1f;

    void FixedUpdate()
    {
        Vector2 temp = transform.position;
        // to move back and forth... +side is right side
        if (Input.GetAxis("Horizontal") > 0)
        {
            temp.x += moveSpeed * Time.deltaTime;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            temp.x -= moveSpeed * Time.deltaTime;
        }
        // to move up and down... +side is right side
        if (Input.GetAxis("Vertical") > 0)
        {
            temp.y += moveSpeed * Time.deltaTime;
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            temp.y -= moveSpeed * Time.deltaTime;
        }
        transform.position = temp;
    }
} //class
