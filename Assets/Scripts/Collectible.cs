using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void Start()
    {
        ScoreText.GemAmount = 0; 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            ScoreText.GemAmount += 1;
            Destroy(gameObject);
        }
    }
}
