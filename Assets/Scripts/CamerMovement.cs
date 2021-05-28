using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerMovement : MonoBehaviour
{
    Transform playerTransform;
    public float offset;
    public float offset2;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //assigning cameras position to temp
        Vector2 temp = transform.position;

        //assigning player position x to temp x
        temp.x = playerTransform.position.x;
        temp.y = playerTransform.position.y;
        //offset of camera
        temp.x += offset;
        temp.y += offset2;

        //assigning changed temp value to original camera position to change the original cam position
        transform.position = temp;
    }
}
