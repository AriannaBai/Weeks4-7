using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public AudioSource fireSound;
    public float bulletSpeed = 10f;

    void Start()
    {
        if (fireSound != null)
        {
            fireSound.Stop();
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FireBullet();
        }
    }

    void FireBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.AddComponent<BulletMovement>().speed = bulletSpeed;

        if (fireSound)
        {
            fireSound.Play();
        }
    }
  
}


