using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishedScore : MonoBehaviour
{
    public Text Score;
    public static FinishedScore instance;
    public Prefs Prefs;
    public float BestScore;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        Prefs.LoadGame();
        if (ScoreCounter.instance.Score > BestScore)
        {
            BestScore = ScoreCounter.instance.Score;
            Prefs.SaveGame();
        }
        Score.text = "—чет:\n" + Mathf.Round(ScoreCounter.instance.Score).ToString() + " м.\n\n" + "Ћучший счет:\n" + Mathf.Round(BestScore).ToString() + " м.";
    }
}
