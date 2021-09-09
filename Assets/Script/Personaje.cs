using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public float velocityX = 1;
    public float jumpForce = 30;

    private Rigidbody2D rb;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velocityX,rb.velocity.y);
       // animator.SetInteger("Estado", 0);
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(Vector2.up*jumpForce,ForceMode2D.Impulse);
            animator.SetInteger("Estado",1);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("morir"))
        {
            Debug.Log("muerte");
            animator.SetInteger("Estado", 2);
            Application.Quit();
        }
    }
}
