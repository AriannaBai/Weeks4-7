using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class clockhand : MonoBehaviour

{
    public float S = 5f;
    public AudioSource chime;
    public AudioClip clip;

    public GameObject bird;

    public int chimeCount;

    // Start is called before the first frame update
    void Start()
    {
        bird.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 CH = transform.eulerAngles;
        CH.z -= S * Time.deltaTime;
        transform.eulerAngles = CH;

        int clockSpeed = (int)CH.z;

        if (Mathf.Abs(clockSpeed % 30) == 0)
        {
            if (chime.isPlaying == false)
            {
                chime.PlayOneShot(clip);
                bird.SetActive(true);
            }
        }

        else

        {
            bird.SetActive(false);
        }
    }
}
  
 

