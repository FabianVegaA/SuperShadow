using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    void Update()
    {
        if(transform.position.y > 5 || transform.position.y < -5.1)
        {
            SceneManager.LoadScene("Intro");
            GameControler.Score = 0;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("Intro");
        GameControler.Score = 0;
    }
    
}
