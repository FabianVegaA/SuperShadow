using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obtaculos : MonoBehaviour
{
    public float velocidad;
    public Enemigo enemigo;

    private void Awake()
    {
        enemigo = GetComponent<Enemigo>();
    }

    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * velocidad,Space.World);
        if(transform.position.x < -12)
        {
            transform.position = new Vector3(20, -3, 0);
            MostrarObjetosAleatorios();
            enemigo?.Nacer();
        }
    }

    private void MostrarObjetosAleatorios()
    {
        int numRamdom = UnityEngine.Random.Range(0,5);
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            bool mostrarChild = numRamdom == i;
            child.gameObject.SetActive(mostrarChild);
        }
    }
    private void OnEnable()
    {
        MostrarObjetosAleatorios();
    }
}
