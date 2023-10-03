using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CScript : MonoBehaviour
{
    SpriteRenderer sr;
    Animator anim;
    [SerializeField] Transform groundCheckCollider;
    [SerializeField] LayerMask groundLayer;
    public Rigidbody2D rb;

    const float groundCheckRadius = 0.2f;
    bool isGrounded = false;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        print("start");
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();


    }


    // Update is called once per frame


    void Update()
    {
        sr.flipX = false;

        int speed = 10;
        int jumpAmount = 7;
        anim.SetBool("Run", false);
        anim.SetBool("Jump", false);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            anim.SetBool("Jump", true);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("player pressed attack");
            anim.SetTrigger("Attack");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("player pressed attack");
            anim.SetTrigger("Attack2");
        }



        DoRun();
        CheckForGround();




        void DoRun()
        {
            if (Input.GetKey(KeyCode.LeftArrow) == true)
            {
                print("player pressed left");
                transform.position = new Vector2(transform.position.x - (speed * Time.deltaTime), transform.position.y);
                anim.SetBool("Run", true);
                sr.flipX = true;
            }



            if (Input.GetKey(KeyCode.RightArrow) == true)
            {
                print("player pressed right");
                transform.position = new Vector2(transform.position.x + (speed * Time.deltaTime), transform.position.y);
                anim.SetBool("Run", true);
                sr.flipX = false;
            }



        }
   
    }

    void CheckForGround()
    {
        isGrounded = false;
       
        Collider2D[] collider = Physics2D.OverlapCircleAll(groundCheckCollider.position, groundCheckRadius, groundLayer);
        if (collider.Length > 0)
            isGrounded = true;
              
    } 







}
