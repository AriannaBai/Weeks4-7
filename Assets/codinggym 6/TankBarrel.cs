using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBarrel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateBarrel();
    }

    void RotateBarrel()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = transform.position.z;
        transform.right = mousePos - transform.position;
    }
}
