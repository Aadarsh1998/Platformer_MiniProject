using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    
   public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        SceneManager.LoadScene(0);
    }
        
}
