using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroPolicialTeste : MonoBehaviour
{
    public WinLoose WinLooseScript;
    [SerializeField] Transform jogador; // o jogador a ser seguido
    private Rigidbody2D rb;
    private Vector2 movimento;
    [SerializeField] float moveSpeed = 5f;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        teste();
    }

    void teste()
    {
        transform.position = Vector2.MoveTowards(transform.position, jogador.transform.position, moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Destroy(other.gameObject, destroyDelay);
            Debug.Log("Morreu!");
            WinLooseScript.perderHard();
        }
    }
}
