using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemigo : MonoBehaviour
{
    public float Variante = 1;
    void Update()
    {
        transform.position += Vector3.up * Mathf.Sin(Time.time) * 
            Time.deltaTime * Variante;
    }
}
