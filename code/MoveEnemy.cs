using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float x1;
    public float x2;
    public float speed;
    void Update()
    {
        
        if (transform.position.x >= x2)
        {
            speed = -3f;
        }
        if (transform.position.x <= x1)
        {
            speed = 3f;
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);

    }
}
