using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//I create this script tp realize the effect of timer.
//I would like to make a timer, and when you click the left ad right button, the timer will reset. 
//To simulate the spotify music switching effect.

public class Timer : MonoBehaviour
{
    public Slider slider; //This is to activate the slider in unity. 
    public float t = 0f; //I set a value of the time, so that it start at o.
    public float spd = 0.01f;//This controls the speed of timer to make it move more slowly, to simulate the music timer effect. 

    public TextMeshProUGUI PlayText;//This is the text UI element that will display the timer value.


    // Start is called before the first frame update
    void Start()
    {
        slider.value = 0;// the oringinal slider will be set to 0 at the start of play. 
        UpdatePlayingText();//update the text, by calling the function I set below.

    }

    // Update is called once per frame
    void Update()
    {
        t += spd;//increase the slider's speed
        slider.value = Mathf.Lerp(slider.value, t, Time.deltaTime * 0.01f);
        // let the slider increase by muiltiplying the delta time, to simulate the music playing effect, it should be slowly. Also make it more smooth using lerp concept. 

        UpdatePlayingText();//refresh the playing text to show the updated time. 

    }
    public void ResetTime()
    {
        //the time should be reset when switching to the next album.
        t = 0; //the value here is to reset the timer to 0 first.
        slider.value = 0;//reset the slider UI to reflect the reset timer.

    }

    void UpdatePlayingText()
    {
        //how could the time test be existing in the screen? I write a if statement to crarify the condition. 
        if (PlayText)
        {
            PlayText.text = "Play: " + slider.value.ToString("00.00"); //use To String to set the format of playing timer. For example - Play: 00:00; 
        }
    }
}



