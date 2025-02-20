using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankMove : MonoBehaviour
{
    public float Speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 objectTank = transform.position;
        objectTank.x += Input.GetAxisRaw("Horizontal") * Speed * Time.deltaTime;
        transform.position = objectTank;
    }
}
