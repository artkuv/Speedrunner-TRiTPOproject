using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveClouds : MonoBehaviour
{
    
    [SerializeField]
    private float fallSpeed = 1f;//Скорость падения
   
    void Update()
    {
        if (transform.position.x > 11f)
        {
            Destroy(gameObject);
        }
        transform.position += new Vector3(fallSpeed * Time.deltaTime, 0, 0);
    }
}
