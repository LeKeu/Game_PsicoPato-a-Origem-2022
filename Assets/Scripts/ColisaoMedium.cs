using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColisaoMedium : MonoBehaviour
{
    [SerializeField] Sprite novaSprite;
    [SerializeField] GameObject carro;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Pessoa")
        {
            if(GameObject.FindGameObjectsWithTag("Pessoa").Length <= 1){
                SceneManager.LoadScene("WinMedium");
            }else{
                other.GetComponent<SpriteRenderer>().sprite = novaSprite;
                other.tag = "Patinho";
                CriarCarro1();
                CriarCarro2();
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
}
