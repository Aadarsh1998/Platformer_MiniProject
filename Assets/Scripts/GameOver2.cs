using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver2 : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(2);
    }
    public void Quit()
    {
        SceneManager.LoadScene(0);
    }
}
