using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public float x1 ;
    public float x2 ;
    public float speed ;
    void Update()
    {
        if(transform.position.x>x2)
        {
            speed = -3f;
        }
        if(transform.position.x<x1)
        {
            speed = 3f;
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);

    }

    private void OnCollisionEnter2D(Collision2D collision)//Когда персонаж нах-ся на платформе 
    {
        if (collision.gameObject.tag== "Player")
        {


            collision.collider.transform.SetParent(transform);//то он движется вместе с платформой 

        }

    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.collider.transform.SetParent(null);
        }
    }

}
 
 