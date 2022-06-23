using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ScoreCounter : MonoBehaviour
{
public static ScoreCounter instance;
    static public string path;
    public float Score;
    public GameObject Character;
    public Text ScoreText;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void FixedUpdate()
    {
        if (PlayerController2D.instance.rb2d.velocity.y > 0 && transform.position.y > Score)
        {
            Score = transform.position.y;
            //Debug.Log(Score);
        }
        ScoreText.text = "—чет: \n" + Mathf.Round(Score).ToString() + " м.";
    }
}
