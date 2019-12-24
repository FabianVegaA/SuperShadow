using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int puntaje;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameControler.Score += puntaje;
    }
}
