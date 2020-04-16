using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSaw : MonoBehaviour
{
    public float x1 = 38f;
    public float x2 = 48f;
    public float speed = 7f;
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 0, 5f));

        transform.Translate(speed * Time.deltaTime, 0, 0);
        if (transform.position.x > x2)
        {
            speed = -speed;
        }
        if (transform.position.x < x1)
        {
            speed = 7f;
        }

    }
}
