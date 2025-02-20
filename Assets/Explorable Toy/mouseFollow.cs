using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseFollow : MonoBehaviour
{
    private bool CharacterMouseFollow = false;//Boolean to track if the character should follow the mouse.


    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(1))//Check if the right mouse button is clicked.
        {
            CharacterMouseFollow = true;

        }

        //If the character should follow the mouse, update its position.
        if (CharacterMouseFollow)
        {
            Vector3 mousePosition = Input.mousePosition;//Get the current mouse position in screen space.

            mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 10));
            //Convert the screen position to world coordinates, so that it will be seen in the screen. 

            transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
            //Update the character's position to match the mouse.

        } 

    }
}


