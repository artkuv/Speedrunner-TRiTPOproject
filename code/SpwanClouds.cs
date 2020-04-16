using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanClouds : MonoBehaviour
{
    public GameObject Clouds;
    void Start()
    {
        
        StartCoroutine(Spawn());//Создаём корутину(выполнть через какой-то промежуток времени)
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            Instantiate(Clouds, new Vector2(-10.7f, Random.Range(1.80f, 4.30f)), Quaternion.identity);//Создаём бомбу
            yield return new WaitForSeconds(Random.Range(0.1f, 8));//Время через которе создастся новая бомба 
        }
    }
}
