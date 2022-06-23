using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformJump : MonoBehaviour
{
    public float forceJump;
    public static FinishedScore instance;
    public AudioSource Jump;
    public AudioClip PlayerJump;
    public float volume = 0.5f;




    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
            PlayerController2D.instance.rb2d.velocity = Vector2.up * forceJump;
                Jump.PlayOneShot(PlayerJump, 0.5f);
            
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "EndGameZone")
        {
            float RandX = Random.Range(-8.7f, -1.1f);
            float RandY = Random.Range(transform.position.y + 18f, transform.position.y + 19f);

            transform.position = new Vector3(RandX, RandY, 0);
        }
    }
}
