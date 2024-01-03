using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public float DestroyItemTime = 5.0f;
    public abstract void DestroyAfterTime();

    public abstract void ApplyItem();

    private void Start()
    {
        DestroyAfterTime();
    }
}
