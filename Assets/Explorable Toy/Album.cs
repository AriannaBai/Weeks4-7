using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Album : MonoBehaviour
{
    public float slideSpeed = 5;
    bool slidE = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (slidE == true)
        {
            SlideOn();
        }
    }

    public void SlideOn()
    {
        Vector2 slide = transform.position;
        slide.x += slideSpeed * Time.deltaTime;
        transform.position = slide;

        if(slide.x >= 10)
        {
            slidE = false;
        }
    }

    public void yesYes()
    {
        slidE = true;
    }
}
