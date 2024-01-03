using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    [SerializeField] private GameObject bulletFactory;
    // [SerializeField] private float forcePower = 10f;

    [SerializeField] private GameObject firePosition;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }

        if (Input.GetMouseButtonDown(0))
        {
            // for (int i = 0; i < 3; i++)
            {
                GameObject bullet = Instantiate(bulletFactory) as GameObject;
                bullet.transform.position = firePosition.transform.position;
                // Vector3 bulletPos = transform.position;

                // bulletPos.y += 0.3f * i;
                // bullet.transform.position = bulletPos;

                // bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * forcePower, ForceMode2D.Impulse);
                bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 5, ForceMode2D.Impulse);
            }
        }
    }
}