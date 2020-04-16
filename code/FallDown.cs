using UnityEngine;

public class FallDown : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed = 12f;//Скорость падения
    public GameObject explosion;
   
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "Platform" || col.gameObject.tag=="saw")//Если бомба коснулась игрока 
        {
            Sound.PlaySound("explosion");
            Destroy(gameObject);
            Instantiate(explosion, transform.position, transform.rotation = Quaternion.identity);
            
        }
       
    }
    void Update()
    {
        if(transform.position.y<-6f)//Если бомба упала-удаляем её(по Y < 6)
        {
            Destroy(gameObject);
        }
        transform.position -= new Vector3(0,fallSpeed*Time.deltaTime,0);//падение бомбы по оси Y
    }
}
