using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    public GameObject proyectil;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var bala = Instantiate(proyectil, 
                transform.position + new Vector3(2,0,0),
                proyectil.transform.rotation);
        }
    }
}
