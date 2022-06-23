using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseCheck : MonoBehaviour
{
    public GameObject CanvasPause;

    public void Pause()
    {
        if //(ButtonScript.instance.check == 0)
            (Time.timeScale != 0)
            CanvasPause.SetActive(false);
        else 
            CanvasPause.SetActive(true);
    }
     void Start()
    {
        CanvasPause.SetActive(false);
    }
}
