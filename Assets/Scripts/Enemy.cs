using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sprite;
    public float enemySpeed;
    public GameObject enemy;
    public GameObject minposition;
    public GameObject maxposition;
    bool moveRight;
    bool moveLeft;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        moveRight = true;
    }

    private void Update()
    {
        minpos();
        maxpos()
;        if(moveRight == true)
        {
            transform.Translate(Vector2.right * enemySpeed);
        }
        if(moveLeft == true)
        {
            transform.Translate(Vector2.left * enemySpeed);
        }
        
    }
    void minpos()
    {
       if(enemy.transform.position.x <= minposition.transform.position.x)
        {
            moveLeft = false;
            moveRight = true;
            sprite.flipX = false;
        }
    }
    void maxpos()
    {
        if(enemy.transform.position.x >= maxposition.transform.position.x)
        {
            moveRight = false;
            moveLeft = true;
            sprite.flipX = true;
        }
    }
//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        if(collision.gameObject.CompareTag("FlipEnemy2"))
//        {
//            moveRight = false;
//            moveLeft = true;
//            sprite.flipX = true;
//        }
//        if(collision.gameObject.CompareTag("FlipEnemy"))
//        {
//            moveLeft = false;
//            moveRight = true;
//            sprite.flipX = false;
//        }
//    }
//    private void OnCollisionEnter2D(Collision2D collision)
//    {
//        //if(collision.gameObject.CompareTag("Player"))
//        //{
//        //    Destroy(collision.gameObject);
//        //}
//    }
}
