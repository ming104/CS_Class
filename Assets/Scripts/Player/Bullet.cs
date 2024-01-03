using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroySelf());
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.up;
        transform.position += direction * bulletSpeed * Time.deltaTime;
    }
    IEnumerator DestroySelf()
    {
        yield return new WaitForSeconds(2.0f);
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
}
