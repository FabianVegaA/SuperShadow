using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject proyectil;
    public float velocidad;

    private void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * velocidad,Space.World);
    }
    
}
