using System.Collections;
using UnityEngine;

public class SpawnBomb : MonoBehaviour
{
    public GameObject bomb;
    void Start()
    {
        
        StartCoroutine(Spawn());//Создаём корутину(выполнть через какой-то промежуток времени)
    }
   
    IEnumerator Spawn()
    {
        while (true )
        {
            Instantiate(bomb, new Vector2(transform.position.x, 15.01f), Quaternion.identity);//Создаём бомбу
            yield return new WaitForSeconds(Random.Range(15.5f, 30.5f));//Время через которе создастся новая бомба 
        }
    }
   
}
