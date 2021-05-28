using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreasureScript : MonoBehaviour
{
    Text text2;
    public static int TreasureAmount = 0;
    void Start()
    {
        text2 = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text2.text = TreasureAmount.ToString();
    }
}
