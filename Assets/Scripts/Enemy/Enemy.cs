using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float health = 10.0f;
    public float speed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("health : " + health);
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Die();
        }
    }
    public virtual void Move()
    {

    }
    private void TakeDamage(int value)
    {
        health -= value;
    }
    private void TakeDamage(float ratio)
    {
        health-=(int)(health * ratio);
    }
    public float Health
    {
        get { return health; }
    }
    private float GetHealth()
    {
        return health;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(50);
            Destroy(collision.gameObject);
        }
    }
    private void Die()
    {
        Destroy(gameObject);
    }
}