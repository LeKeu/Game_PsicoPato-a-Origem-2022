using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroPoliciaTesteMedium : MonoBehaviour
{
    public WinLoose WinLooseScript; // to meio q importando esse script p utilizar as funções dele
    [SerializeField] Transform jogador; // o jogador a ser seguido
    private Rigidbody2D rb;
    private Vector2 movimento;
    [SerializeField] float moveSpeed = 5f;
    //[SerializeField] float destroyDelay = 0.5f;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direcao = jogador.position - transform.position; // eu pego a direção do meu jogador
        float angulo = Mathf.Atan2(direcao.y, direcao.x) * Mathf.Rad2Deg;
        // a função acima retorna um valor em radiano mas tem q ser degrees, ent multi. pelo Rad2Deg, que faz isso
        rb.rotation = angulo - 90f; //botei -90 pq o sprite tava ficando de lado, ai -90 bota na posição certa
        direcao.Normalize(); // o valor tem q ser entre -1 e +1, o Normalize faz isso pelo q eu entendi
        movimento = direcao;
    }

    private void FixedUpdate()
    { // ele disse "já que estamos lidando com física(mov do carro) é bom fazer isso num FixedUpdate
        moverCarro(movimento);
    }

    void moverCarro(Vector2 direcao)
    {
        rb.MovePosition((Vector2)transform.position + (direcao * moveSpeed * Time.deltaTime));
        //a linha acima pega a posição atual e mover na direção especificada com vel do carro junto com o delta time pra "ajeitar" as frames
        //o (Vector2) ajusta para ser um vetor de 2 e não de 3 como tava dando erro sem ele, não entendi mt bem...
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Destroy(other.gameObject, destroyDelay);
            Debug.Log("Morreu!");
            WinLooseScript.perderMedium();
        }
    }

}
