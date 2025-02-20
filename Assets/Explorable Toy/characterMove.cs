using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class characterMove : MonoBehaviour
{
    public float speed = 0.3f;
    void Start()
    {
        Destroy(gameObject, 8);//Destroy the object after 8 seconds to prevent infinite movement.

    }

    // Update is called once per frame
    void Update()
    {
        //Get current position of the object.
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;//Move the object horizontally based on speed and time.

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);//Convert position to screen coordinates

        //Check if the object has moved off the left side of the screen.
        if (screenPos.x < 0)
        {
            //Reposition it to the left edge and reverse its direction.
            Vector3 fixedPos = new Vector3(0, 0, 0);
            pos.x = Camera.main.WorldToScreenPoint(fixedPos).x;
            speed = speed * -1;

        }

        //Check if the object has moved off the right side of the screen.
        if (screenPos.x > Screen.width)
        {
            Vector3 fixedPos = new Vector3(Screen.width, 0, 0);
            pos.x = Camera.main.WorldToScreenPoint(fixedPos).x;
            speed = speed * -1;
        }
        transform.position = pos;//Apply the update position to the created object.
    }
} 


