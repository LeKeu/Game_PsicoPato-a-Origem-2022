using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colisao : MonoBehaviour
{
    [SerializeField] Sprite novaSprite;
    [SerializeField] GameObject carro;


    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Passou por mim?");
        if (other.tag == "Pessoa")
        {
            if(GameObject.FindGameObjectsWithTag("Pessoa").Length <= 1){
                SceneManager.LoadScene("Win");
            }else{
                other.GetComponent<SpriteRenderer>().sprite = novaSprite;
                other.tag = "Patinho";
                CriarCarro();
            }
        }
    }

    void CriarCarro(){
        GameObject a = Instantiate(carro) as GameObject;
        a.transform.position = new Vector2(5, -4);
    }

}
