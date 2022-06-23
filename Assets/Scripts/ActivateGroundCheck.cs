using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGroundCheck : MonoBehaviour
{
    public GameObject GroundCheck, GroundCheckL, GroundCheckR;

    void Update()
    {
            GroundCheck.SetActive(true);
            GroundCheckR.SetActive(true);
            GroundCheckL.SetActive(true);
    }
}
