using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class sliderRotation : MonoBehaviour
{
    public Transform targetSprite;
    public Slider rotationSlider;

    void Update()
    {
        if (rotationSlider != null && targetSprite != null)
        {
            targetSprite.rotation = Quaternion.Euler(0, 0, rotationSlider.value);
        }
    }
}
