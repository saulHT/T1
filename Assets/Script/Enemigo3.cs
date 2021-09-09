using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo3 : MonoBehaviour
{
    public float fuerzaSalto = 40;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        // rb.AddForce(new Vector2(0,fuerzaSalto),ForceMode2D.Impulse);
       // rb.AddForce(Vector2.up * -fuerzaSalto, ForceMode2D.Impulse);

    }
}
