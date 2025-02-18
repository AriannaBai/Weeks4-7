using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider slider; 
    public float t = 0f; // the value of the time
    public float speedFactor = 0.001f;//control the speed to get more slowly

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 0;// te oringinal slider
        
    }

    // Update is called once per frame
    void Update()
    {
        t += speedFactor;//increase the slider's speed
        slider.value = Mathf.Lerp(slider.value, t, Time.deltaTime * 0.001f); // let the slider increase
    }
    public void ResetTime()
    {
        t = 0;
        slider.value = 0; 

    }
   
}
