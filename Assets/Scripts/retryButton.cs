using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retryButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGameEasy(){
        SceneManager.LoadScene("EasyMode");
    }

    public void LoadGameHard(){
        SceneManager.LoadScene("HardMode");
    }

    public void startGameEasy(){
        SceneManager.LoadScene("EasyMode");
    }

    public void startGameHard(){
        SceneManager.LoadScene("HardMode");
    }

    public void winRetry(){
        SceneManager.LoadScene("Menu");    
    }
}
