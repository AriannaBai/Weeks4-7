using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Album : MonoBehaviour
{
    public float moveDistance = 13f; // the distanve for every move

    void Start() // the way to click before the game start 
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
}