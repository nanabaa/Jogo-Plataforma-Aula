using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private float horizontal;
    private Rigidbody2D  rb;
    private bool isFacingRight = true;
    public Animator animator;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);
        this.rb.velocity = new Vector2(horizontal * 8f, rb.velocity.y);
        animator.SetFloat("speed", Mathf.Abs(horizontal));
        Flip();
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Apertou espa�o");
        }
        if (Input.GetMouseButtonDown(0)) 
        {
            Debug.Log("Clicou com o botao direito");
        }
        */
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f) 
        { 
            isFacingRight = !isFacingRight;
            Vector2 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
