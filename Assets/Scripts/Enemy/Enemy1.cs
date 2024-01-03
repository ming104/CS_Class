using UnityEngine;

public class Enemy1 : Enemy
{
    private Vector2 _direction;
    private GameObject _player;
    // private bool _isGameOver;
    
    // private void Update()
    // {
    //     if (_isGameOver)
    //     {
    //         Time.timeScale = 0f;
    //     }
    // }

    public override void Move()
    {
        _player = GameObject.Find("Player");

        try
        {
            _direction = (_player.transform.position - transform.position);
            _direction.Normalize();

            // Debug.Log($"Direction = {_direction}");
            GetComponent<Rigidbody2D>().AddForce(_direction * speed);
        }
        catch
        {
            Debug.Log($"To do : GameOver");
            // _isGameOver = true;
        }
    }
}