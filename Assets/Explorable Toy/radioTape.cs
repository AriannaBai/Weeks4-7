using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class radioTape : MonoBehaviour
{
    public GameObject rectangle; //set a game object for the tape.
    public Slider verticalSlider; //this is a UI setting to activate the slider function in unity.
    public float rectangleMoveRange = 50f; //I set an initial range for the tape. It is like the speed when sliding the slider.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rectangle != null)
        {
            float newX = -rectangleMoveRange * verticalSlider.value;
            //calculate the new position based on the slider value.
            //I multiply this two value to determine how far the rectangle(tape) should move within it's range.
            //I set it to negative to make sure the rectangle moves in the opposite direction. 

            rectangle.transform.position = new Vector3(newX, rectangle.transform.position.y, rectangle.transform.position.z);//apply the new position while keeping y and z unchanged. 
        }
    }
}
