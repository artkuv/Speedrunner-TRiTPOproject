using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveY : MonoBehaviour
{
    public float y1;
    public float y2;
    public float speed;
    void Update()
    {

        if (transform.position.y >= y1)
        {
            speed = -3f;
        }
        if (transform.position.y <= y2)
        {
            speed = 3f;
        }
        transform.Translate(0, speed * Time.deltaTime, 0);

    }
}
