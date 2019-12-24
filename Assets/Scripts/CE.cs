using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CE : MonoBehaviour
{
    public void CambioScena()
    {
        SceneManager.LoadScene("Game");
        GetComponent<AudioSource>().Play();
    }

}
