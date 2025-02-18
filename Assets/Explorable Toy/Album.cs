             using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Album : MonoBehaviour
{
    AudioSource audio;
    public float moveDistance = 13f; // the distanve for every move
    public int number = 1;
    public AudioClip[] musics;
    bool play = true;

    void Start() // the way to click before the game start 
    {
        audio = GetComponent<AudioSource>();
        if (play)
        {
            audio.PlayOneShot(musics[number]);
        }
    }

    private void Update()
    {
        
    }
    public void MoveLeft() // the way to switch to the left song
    {
        Vector2 moveLeft = transform.position;
        moveLeft.x -= moveDistance;
        transform.position = moveLeft;
    }

    public void MoveRight() // the way to switch the write song
    {
        Vector2 moveRight = transform.position;
        moveRight.x += moveDistance;
        transform.position = moveRight;
    }

    public void ClipChangeL()
    {
        play = false;
        number -= 1;
        audio.PlayOneShot(musics[number]);
    }
    public void ClipChange()
    {
        play = false;
        number += 1;
        audio.PlayOneShot(musics[number]);
    }
}