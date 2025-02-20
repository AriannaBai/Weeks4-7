using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Here is the album audio script, it will be linked to the movement script so that the correct music will be actived and played, when the corresponding album is switched.
public class AlbumAudio : MonoBehaviour
{
    private AudioSource audioSource; //this variable handles playing audio reference.
    public int number = 0;
    //this variable keeps track of the currently playing song.
    //I set the initial number to 0. It should start at 0.
    public AudioClip[] musics;
    //I create an array to hold multiple music tracks.
    //Each element represents a different song that can be played.

    void Start()
    {
        //I use the same logic as the movement script, to make sure the player can control the audio sources.
        audioSource = GetComponent<AudioSource>();
        PlayMusic(); //To active the first song when clicking the play button. 
    }

    public void PlayMusicByTracking(int index)
    {
        //I add a funcition to make sure the right song is played based on the right number. 
        //This can also prevents errors caused by accessing invalid array positions.
        if (index >= 0 && index < musics.Length)
        {
            number = index;//make sure the updates matches the right album number. 
            PlayMusic(); //the song will be activated.
        }
    }

    private void PlayMusic()
    {
        //Make sure there are available musics and the selected album is valid and correct.
        if (musics.Length > 0 && number >= 0 && number < musics.Length) 
        {
            audioSource.clip = musics[number];//make the selected song to the AudioSource component.

            audioSource.Play();//now start playing the selected music.
             
        }
    }
}