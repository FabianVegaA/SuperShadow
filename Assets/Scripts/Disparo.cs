using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public Vector2 VelocidadInicial;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = VelocidadInicial;
        Destroy(this.gameObject, 2.8f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemigo = collision.collider.GetComponent<Enemigo>();
        enemigo?.Muerte();
        Destroy(this.gameObject);

    }
}