using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health = 50.0f;

    private void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }
    void TakeDamage(int value)
    {
        health -= value;
    }
    void Die()
    {
        Destroy(this.gameObject);    
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(50);
            Destroy(collision.gameObject);
        }
    }
}
