using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class radioTape : MonoBehaviour
{
    public GameObject rectangle; 
    public Slider verticalSlider; 
    public float rectangleMoveRange = 50f; 
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
            rectangle.transform.position = new Vector3(newX, rectangle.transform.position.y, rectangle.transform.position.z);
        }
    }
}
