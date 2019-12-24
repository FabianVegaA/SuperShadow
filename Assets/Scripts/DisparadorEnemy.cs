using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparadorEnemy : MonoBehaviour
{
    public GameObject proyectil;

    public void Update()
    {
        int desicion = UnityEngine.Random.Range(0, 2);
        if (desicion == 1)
        {
            
        }
    }
    public void Disparo()
    {
        var bala = Instantiate(proyectil);
    }
}
