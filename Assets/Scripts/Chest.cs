using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    Animator anim;
    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetInteger("ChestAnim", 0);
        TreasureScript.TreasureAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            anim.SetInteger("ChestAnim", 1);
            TreasureScript.TreasureAmount += 1;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag == "Player")
        {
            anim.SetInteger("ChestAnim", 2);
            Destroy(gameObject, 0.7f);
        }
    }
}
