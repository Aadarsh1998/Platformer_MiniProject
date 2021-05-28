using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignBoard : MonoBehaviour
{
    public GameObject dialogueBox;
    public Text text;
    bool textActive = false;
    // Start is called before the first frame update
    void Start()
    {
        dialogueBox.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            dialogueBox.SetActive(true);
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        dialogueBox.SetActive(false);
    }
}
