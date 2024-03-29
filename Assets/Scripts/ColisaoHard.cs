using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColisaoHard : MonoBehaviour
{
    [SerializeField] Sprite novaSprite;
    [SerializeField] GameObject carro;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Pessoa")
        {
            if(GameObject.FindGameObjectsWithTag("Pessoa").Length <= 1){
                SceneManager.LoadScene("WinHard");
            }else{
                other.GetComponent<SpriteRenderer>().sprite = novaSprite;
                other.tag = "Patinho";
                CriarCarro1();
                CriarCarro2();
                CriarCarro3();
            }
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

    void CriarCarro3(){
        GameObject a = Instantiate(carro) as GameObject;
        a.transform.position = new Vector2(-40, -1);
    }

}
