using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5;
    public float runSpeed = 7;
    public float jumpForce = 5;
    public Rigidbody2D rb;
    public Animator anim;
    public SpriteRenderer  SpriteRenderer;

    public GoundCheker groundCheker;
    public playerhealth health;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        health= GetComponent <playerhealth >();
        anim= GetComponent<Animator>();
        SpriteRenderer = GetComponent<SpriteRenderer>();

    }

    void Update()

    {
        {
            anim.SetBool("isGrounded", groundCheker.isGrounded);
            anim.SetFloat("YVelocity",rb.velocity.y);

            if (Input.GetKeyDown(KeyCode.Space) && groundCheker.isGrounded)
            {
                rb.AddForce(Vector2.up *jumpForce);
                anim.SetTrigger("Jump");
            }
        }
        if(health.IsDead) return;
        float moveInput = Input.GetAxis("Horizontal");

         if(moveInput >= 0)
        {
            SpriteRenderer.flipX = false;
        }
         else if(moveInput < 0)
        {
            SpriteRenderer.flipX = true;
        }

        if(moveInput != 0)
        {
            anim.SetBool("IsRun", true);
        }
        else
        {
            anim.SetBool("IsRun", false);
        }
        //Debug.Log($"Input value: {moveInput}");
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.velocity = new Vector2(moveInput * runSpeed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space) && groundCheker.isGrounded)
        {
            //rb.AddForce(new Vector2(0,jumpForce));
            rb.AddForce(Vector2.up * jumpForce);
            
        }
        
        }
        
    }
      
     
   

