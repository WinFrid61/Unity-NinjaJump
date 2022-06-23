using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefs : MonoBehaviour
{

    public void SaveGame()
    {
        PlayerPrefs.SetFloat("SavedBestScore", FinishedScore.instance.BestScore);
        PlayerPrefs.Save();
        Debug.Log("Game data saved!");
        Debug.Log("Сохранено: ");
        Debug.Log(FinishedScore.instance.BestScore);
    }   
    public void LoadGame()
    {
        if (PlayerPrefs.HasKey("SavedBestScore"))
        {
            FinishedScore.instance.BestScore = PlayerPrefs.GetFloat("SavedBestScore");
            Debug.Log("Game data loaded!");
            Debug.Log("Что мы имеем - Лучший счет");
            Debug.Log(FinishedScore.instance.BestScore);
        }
        else
            Debug.Log("Game data not found!");
    }
    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
    }
}
