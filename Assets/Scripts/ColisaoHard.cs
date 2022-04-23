using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColisaoHard : MonoBehaviour
{
    [SerializeField] Sprite novaSprite;
    [SerializeField] GameObject carro;
    int qntd = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Pessoa")
        {
            if(qntd == 5){
                SceneManager.LoadScene("Win");
            }else{
                other.GetComponent<SpriteRenderer>().sprite = novaSprite;
                other.tag = "Patinho";
                qntd++;
                CriarCarro1();
                CriarCarro2();
            }
        }
        if(other.tag == "Patinho"){
            Debug.Log("PATINHOOO");
        }
    }

    void CriarCarro1(){
        GameObject a = Instantiate(carro) as GameObject;
        a.transform.position = new Vector2(5, -4);
    }

    void CriarCarro2(){
        GameObject a = Instantiate(carro) as GameObject;
        a.transform.position = new Vector2(-15, 22);
    }

}
