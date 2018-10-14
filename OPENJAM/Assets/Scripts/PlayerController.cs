using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    AudioSource source;
    public float moveX = 2f;
    public static bool canmove;
    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
        PlaySound();
        canmove = true;
    }

    void PlaySound()
    {
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (canmove == true)
        {
            Movement();
        }
    }


    void Movement()
    {
        if (Input.GetKey(KeyCode.D) && transform.position.x < 7f)
        {
            Vector2 pos = new Vector2(transform.position.x + moveX, transform.position.y);
            transform.position = pos;
        }
        if (Input.GetKey(KeyCode.A) && transform.position.x > -7f)
        {
            Vector2 pos = new Vector2(transform.position.x - moveX, transform.position.y);
            transform.position = pos;
        }
    }
}












