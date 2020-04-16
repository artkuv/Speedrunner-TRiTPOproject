using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatfY : MonoBehaviour
{
    public float y1;
    public float y2;
    public float speed;
    void Update()
    {

        if (transform.position.y >= y1)
        {
            speed = -0.5f;
        }
        if (transform.position.y <= y2)
        {
            speed = 0.5f;
        }
        transform.Translate(0, speed * Time.deltaTime, 0);

    }
}
