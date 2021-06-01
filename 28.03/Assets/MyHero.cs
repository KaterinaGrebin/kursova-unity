using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MyHero : MonoBehaviour
{
    [SerializeField] private AudioSource jumpSound;
    [SerializeField] private AudioSource vragSound;
    [SerializeField] private AudioSource fruitSound;
    [SerializeField] private AudioSource bg1Sound;
    Rigidbody2D rb;// компонент для роботи з "фізикою"
        Animator anim;
    int Score = 0;


   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        bg1Sound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * 15f, rb.velocity.y);

    }
    void Jump()
    {
        rb.AddForce(transform.up * 14f, ForceMode2D.Impulse);
        jumpSound.Play();
    }

    void ReloudLevel()// метод перезавантаження сцен
    {
        Application.LoadLevel(3);
    }


    void OnTriggerEnter2D(Collider2D collision)//груша як живлення для героя
    {
        if (collision.gameObject.tag == "life")//перевіряється на зіткнення
        {
       
            Score++;
            Destroy(collision.gameObject);//груша знищиться
        }
        fruitSound.Play();
      
    }




    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "vrag")//перевіряється на зіткнення
        {
            Invoke("ReloudLevel", 2);//виклик перезавантаження сцени
            
        }
        vragSound.Play();

    }
    void Flip()
    {
        if (Input.GetAxis("Horizontal") > 0) transform.localRotation = Quaternion.Euler(0, 0, 0);
        if (Input.GetAxis("Horizontal") < 0) transform.localRotation = Quaternion.Euler(0, 180, 0);
    }


    void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 100, 30), "SCORE = " + Score);
    }


}

