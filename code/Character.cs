
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    
    public float speed = 4.0f;
    public float jumpforce = 1.0f;
    public Rigidbody2D PlayerRigidbody;//Для прыжка
    public Animator charAnimator;//Для переключений анимаций
    public SpriteRenderer sprite;//Для поворота персонажа влево или вправо
    public Transform groundCheck;
    public float groundRadius = 0.2f;
    bool isGrounded = true;
    public GameObject BtnLeft;//переменные для кнопок
    public GameObject BtnRight;
    public GameObject BtnJump;
    public GameObject BtnPause;
    public GameObject PausePanel;
    public GameObject BtnContinue;//переменные для кнопок
    public GameObject BtnExit;
    public GameObject score;
    public GameObject CoinImage;
    public GameObject FinishMenu;
    public GameObject FinishScore;
    float PosBtnLeft;
    float PosBtnRight;
    float PosBtnJump;
    float PosBtnPause;

    public void Start()
    {
        PosBtnLeft = BtnLeft.transform.position.y;//Запоминаются координаты кнопок
        PosBtnRight = BtnRight.transform.position.y;
        PosBtnJump = BtnJump.transform.position.y;
        PosBtnPause = BtnPause.transform.position.y;
        Time.timeScale = 1f;
        //score.SetActive(true);
        //CoinImage.SetActive(true);
        //FinishMenu.SetActive(false);
    }

    private void Awake()//Срабатывает до старта игры
    {
        PlayerRigidbody = GetComponentInChildren<Rigidbody2D>();
        charAnimator = GetComponentInChildren<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }
   

    //private void Move()
    //{
    //    Vector3 tempvector = Vector3.right * Input.GetAxis("Horizontal");
    //    transform.position = Vector3.MoveTowards(transform.position, transform.position + tempvector, speed * Time.deltaTime);//Перемещение
    //    charAnimator.SetInteger("State", 1);//State-1(Анимация бега)

    //    if (tempvector.x < 0)//если перемещение влево
    //    {
    //        sprite.flipX = true;//поворот персонажа влево
    //    }
    //    else
    //    {
    //        sprite.flipX = false;//вправо
    //    }
    //}


    private void FixedUpdate()
    {
        
        CheckGround();
    }
    private void CheckGround()//Проеверяет соприкосновение с землёй
    {

        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, 0.3F);

        isGrounded = colliders.Length > 1;


    }

    public void ButtonContinue()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
        BtnRight.SetActive(true);
        BtnLeft.SetActive(true);
       
        BtnJump.SetActive(true);
    }

    public void ButtonExit()
    {
        SceneManager.LoadScene("Main menu");
    }

    void Update()
    {
        if (PosBtnLeft != BtnLeft.transform.position.y && PosBtnRight != BtnRight.transform.position.y)//если нажата левая кнопка
        {
            charAnimator.SetInteger("State", 0);//State-0(Анимция на месте)
        }

        if (PosBtnLeft!=BtnLeft.transform.position.y && PosBtnRight == BtnRight.transform.position.y)//если нажата левая кнопка
        {
            Vector3 tempvector = Vector3.left;
            sprite.flipX = true;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + tempvector, speed * Time.deltaTime);
            charAnimator.SetInteger("State", 1);
        }

         if (PosBtnRight != BtnRight.transform.position.y && PosBtnLeft == BtnLeft.transform.position.y)
        {
            Vector3 tempvector = Vector3.right;
            sprite.flipX = false;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + tempvector, speed * Time.deltaTime);
            charAnimator.SetInteger("State", 1);
        }
        
        if (isGrounded && PosBtnJump != BtnJump.transform.position.y)
        {
            charAnimator.SetInteger("State", 2);//State-2(Анимация прыжка)
            Sound.PlaySound("Jump");
            PlayerRigidbody.AddForce(transform.up * jumpforce, ForceMode2D.Impulse);
        }

        if (PosBtnPause != BtnPause.transform.position.y)//Если нажата клавиша паузы
        {
            
            Time.timeScale = 0f;
            PausePanel.SetActive(true);
            BtnRight.SetActive(false);
            BtnLeft.SetActive(false);
          
            BtnJump.SetActive(false);
        }

        

         if (PosBtnLeft == BtnLeft.transform.position.y && PosBtnRight == BtnRight.transform.position.y && PosBtnJump == BtnJump.transform.position.y)//Если никакие клавиши не нажаты
        {
            charAnimator.SetInteger("State", 0);//State-0(Анимция на месте)
        }

        if (Loose.finish == true) {
            Time.timeScale = 0f;
            BtnRight.SetActive(false);
            BtnLeft.SetActive(false);
            BtnJump.SetActive(false);
            BtnPause.SetActive(false);
            score.SetActive(false);
            CoinImage.SetActive(false);
            FinishMenu.SetActive(true);
            FinishScore.GetComponent<UnityEngine.UI.Text>().text = "" + Loose.score;
        }

    }



}
