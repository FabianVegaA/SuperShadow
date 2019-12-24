using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vuelo : MonoBehaviour
{
    public Vector2 Jump;

    public int saltos;

    public void Update()
    {
        

        if (Input.GetButtonDown("Fire1"))
        {
            saltos++;//Esto es par el contador, para el puntaje

            GetComponent<Rigidbody2D>().AddForce(Jump);
            GetComponent<AudioSource>().Play();
        }
    }
}

