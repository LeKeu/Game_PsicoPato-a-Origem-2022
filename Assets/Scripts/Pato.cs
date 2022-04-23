using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pato : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 m;

    // Update is called once per frame
    void Update()
    {
        m.x = Input.GetAxisRaw("Horizontal");
        m.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("speed", moveSpeed);
   
    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + m * moveSpeed * Time.fixedDeltaTime);    
        if (Input.GetAxisRaw("Horizontal") > 0){
            rb.transform.localScale = new Vector3(1, 1, 1);
        }else if(Input.GetAxisRaw("Horizontal") < 0){
            rb.transform.localScale = new Vector3(-1, 1, 1);
        }
    }

}
