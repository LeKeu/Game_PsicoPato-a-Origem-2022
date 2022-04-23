using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colisao : MonoBehaviour
{
    [SerializeField] Sprite novaSprite;
    [SerializeField] GameObject carro;
    int qntd = 0;
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Passou por mim?");
        if (other.tag == "Pessoa")
        {
            if(qntd == 5){
                SceneManager.LoadScene("Win");
            }else{
                other.GetComponent<SpriteRenderer>().sprite = novaSprite;
                other.tag = "Patinho";
                qntd++;
                CriarCarro();
            }
        }
        if(other.tag == "Patinho"){
            Debug.Log("PATINHOOO");
        }
    }

    void CriarCarro(){
        GameObject a = Instantiate(carro) as GameObject;
        a.transform.position = new Vector2(5, -4);
    }

}
