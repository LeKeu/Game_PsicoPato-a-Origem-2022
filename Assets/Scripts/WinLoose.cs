using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLoose : MonoBehaviour
{
    private bool fimDeJogo;
    // Start is called before the first frame update
    public void ganhar()
    {
        if (!fimDeJogo)
        {
            Debug.Log("Ganhou!");
            fimDeJogo = true; // faz isso p acontecer só uma vez a coisa toda
        }
    }

    public void perderEasy()
    {
        if (!fimDeJogo)
        {
            Debug.Log("Perdeu...");
            fimDeJogo = true; // faz isso p acontecer só uma vez a coisa toda
            SceneManager.LoadScene("LoseEasy");
        }
    }

    public void perderMedium()
    {
        if (!fimDeJogo)
        {
            Debug.Log("Perdeu...");
            fimDeJogo = true; // faz isso p acontecer só uma vez a coisa toda
            SceneManager.LoadScene("LoseMedium");
        }
    }

    public void perderHard()
    {
        if (!fimDeJogo)
        {
            Debug.Log("Perdeu...");
            fimDeJogo = true; // faz isso p acontecer só uma vez a coisa toda
            SceneManager.LoadScene("LoseHard");
        }
    }
}
