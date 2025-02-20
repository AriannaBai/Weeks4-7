using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class itemInteraction : MonoBehaviour
{

    public int health = 100;

    void OnMouseDown()
    {
        TakeDamage(10);
    }

    void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
