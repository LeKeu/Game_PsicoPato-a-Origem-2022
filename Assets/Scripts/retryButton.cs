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

    public void startGameEasy(){
        SceneManager.LoadScene("EasyMode");
    }

    public void startGameMedium(){
        SceneManager.LoadScene("MediumMode");
    }

    public void startGameHard(){
        SceneManager.LoadScene("HardMode");
    }

    public void winRetry(){
        SceneManager.LoadScene("Menu");    
    }

    public void sair(){
        Application.Quit();
    }
}
