using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{
    public static int Score = 0;
    public string ScoreString = "Score";
    public Text TextScore;

    public static GameControler Gamecontroller;
    
    void Awaike()
    {
        Gamecontroller = this;
    }

    void Update()
    {

        if (TextScore != null)
        {
            TextScore.text = ScoreString + Score.ToString();
        }
    }
}
