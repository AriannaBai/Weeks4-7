using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class challenge4changeColor : MonoBehaviour
{
    public SpriteRenderer targetSprite;
    public Button changeColorButton;

    public void ChangeColor()
    {
        if (targetSprite != null)
        {
            targetSprite.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
