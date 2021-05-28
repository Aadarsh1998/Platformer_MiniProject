using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer spriteRenderer;
    bool isgrounded;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public float movespeed = 3f;
    public float jumpvelocity = 6f;
    public GameObject EndScreen;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        EndScreen.SetActive(false);
    }

    private void Update()
    {
        movement();
        Attack();
        
    }
    private void FixedUpdate()
    {
        isgrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);  
    }
    void movement()
    {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.velocity = new Vector2(movespeed, rb.velocity.y);
                animator.SetInteger("State", 1);
                spriteRenderer.flipX = false;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.velocity = new Vector2(-movespeed, rb.velocity.y);
                animator.SetInteger("State", 1);
                spriteRenderer.flipX = true;

            }
            
            if (rb.velocity.x == 0)
            {
                animator.SetInteger("State", 0);
            }
            if(Input.GetKey(KeyCode.UpArrow))
            {
                if(isgrounded)
                {
                    rb.velocity = new Vector2(rb.velocity.x, jumpvelocity);
                    animator.SetInteger("State", 2);
                }
                
            }
    }
    void Attack()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetInteger("State", 3);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            EndScreen.SetActive(true);
            Destroy(gameObject);
            //SceneManager.LoadScene(0);
        }
        if(collision.gameObject.CompareTag("Zombie"))
        {
            Destroy(gameObject);
        }
        if(collision.gameObject.CompareTag("Water"))
        {
            EndScreen.SetActive(true);
            Destroy(gameObject, 0.02f);
            //SceneManager.LoadScene(0);
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            //EndScreen.SetActive(true);
            Destroy(gameObject);
            SceneManager.LoadScene(2);
        }
        if (collision.gameObject.CompareTag("EnemyKill"))
        {
            Destroy(collision.gameObject);
            print("EnemyKilled");
        }
        if(collision.gameObject.CompareTag("Exit"))
        {
            SceneManager.LoadScene(3);
        }
    }
   
}
