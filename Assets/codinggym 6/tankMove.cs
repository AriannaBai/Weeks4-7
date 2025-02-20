using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankMove : MonoBehaviour
{
    public float Speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 tank1 = transform.position;
        tank1.x += Input.GetAxisRaw("Horizontal") * Speed * Time.deltaTime;
        transform.position = tank1;
    }
}
