using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCharacter : MonoBehaviour
{
    public GameObject CharacterPrefab;//The character that will be created.


    void Update()
    {
        if (Input.GetMouseButtonDown(1))//Check if the right mouse button is clicked.
        {
            Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);//Get the mouse position and convert it to world coordinates.
            GameObject newCharacter = Instantiate(CharacterPrefab, mouse, Quaternion.identity);//Create a new character at the mouse position with no rotation.
            characterMove movementScript = newCharacter.GetComponent<characterMove>();//Try to get the movement script from the new character.

            //If the movement script is found, give the character a random speed between 1 and 8.
            if (movementScript != null)
            {
                movementScript.speed = Random.Range(1, 8);
            }
            Destroy(movementScript, 8);//Remove the movement script after 8 seconds, so the character stops moving.
             
        }
    }
}



