using UnityEngine;

//Script description:
//The hard part of this effect is to use array to hold all three albums. 
//The problem I face was: I first created three sprites in squares, and set them as father and child.
//However, the audio does not play porperly and it overlaps with each other. 

//To solve this problem, I recreated the albums in canvas, and set them as separate images. Use array to control them and made them individual.
//So it is clear for me to add separade scripts and modify changes in unity. 
//I separade the two scripts into: move and audio.

//This script is responsible for moving between different albums and playing the corresponding audio.

public class AlbumMover : MonoBehaviour
{
    public GameObject[] Albums; //I first create an array to hold all the albums.

    private int TrackingAlbums = 0;//This variable keeps track of which album is currently active or not. 

    private AlbumAudio albumAudio;//A reference that handles playing music.


    void Start()
    {
        albumAudio = GetComponent<AlbumAudio>();
        //I need to make sure the gameobject, in this case the albums is attached to different music sources. 
        //so that player can trigger music playback when switching albums.
        UpdateAlbums();//make sure only the first album is displayed at the start, hiding the others.
    }

    public void MoveLeft()
    {
        // Checks if there is a previous album to move to.
        // Prevents moving left if already at the first album, so set the valuable to 0. 
        if (TrackingAlbums > 0)
        {
            TrackingAlbums--; //This make sures the album move left. 
            UpdateAlbums();//The next step is to prevent it being hidden. 
            albumAudio.PlayMusicByTracking(TrackingAlbums);//plays the corresponding music for the selected album.

        }
    }

    public void MoveRight()
    {
        // Checks if there is another album to move to.
        // make sures the album does not exceed the last element in the array.
        if (TrackingAlbums < Albums.Length - 1)
        {
            TrackingAlbums++; //This make sures the album move to right. 
            UpdateAlbums(); // The next step is to prevent it being hidden.
            albumAudio.PlayMusicByTracking(TrackingAlbums); //same as abve.
        }
    }

    private void UpdateAlbums()
    {
        //I write a loops through all album.

        for (int i = 0; i < Albums.Length; i++)
        {
            //I use set active to make album appear, but only the album at the current state should be visible.
            // Hides all other albums to ensure only one is displayed at a time.
            Albums[i].SetActive(i == TrackingAlbums);
        }
    }
}

