using ming10;
using System.Collections;
using UnityEngine;

public class Coin : Item
{
    public override void DestroyAfterTime()
    {
        //Invoke("DestroyThis", DestroyItemTime);
        StartCoroutine(DestroyThis(3f));
    }

    public override void ApplyItem()
    {
        DestroyThis();
    }
    void DestroyThis()
    {
        Destroy(gameObject);
    }


    IEnumerator DestroyThis(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ApplyItem();
        }
    }
}
