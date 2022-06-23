using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public Transform CharacterPos;

    void Update()
    {
        if (CharacterPos.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, CharacterPos.position.y, transform.position.z);
        }
    }
}
