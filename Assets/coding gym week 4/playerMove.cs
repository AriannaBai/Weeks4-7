using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float Speed = 5.0f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 player1 = transform.position;
        player1.x += Input.GetAxisRaw("Horizontal") * Speed * Time.deltaTime; 
        transform.position = player1;

        Vector2 player2 = transform.position;
        player2.y += Input.GetAxisRaw("Vertical") * Speed * Time.deltaTime;
        transform.position = player2;
    }
}
