using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public AudioSource FSound;
    public float bulletSpeed = 5f;

    void Start()
    {
        if (FSound != null)
        {
            FSound.Stop();
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

        if (FSound)
        {
            FSound.Play();
        }
    }
  
}


