using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ming10{
public class ItemManager : MonoBehaviour
{
    public Point[] Points =
{
        new Point(-3, -5),
        new Point(-3, -3),
        new Point(-3, -1),
        new Point(-3, 1),
        new Point(-3, 3),
        new Point(-3, 5),

        new Point(3, -5),
        new Point(3, -3),
        new Point(3, -1),
        new Point(3, 1),
        new Point(3, 3),
        new Point(3, 5),
    };

    [Header("item Prefab List")]
    public GameObject[] ItemPrefabs = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandom();
        //SpawnItem(ItemPrefabs[0], new Vector2(0, 0));
        //SpawnItem(ItemPrefabs[1], new Vector2(1, 0));
    }

    public void SpawnRandom()
    {
        GameObject prefab = ItemPrefabs[Random.Range(0, ItemPrefabs.Length)];
        Vector2 pos = Points[Random.Range(0, Points.Length)].GetPos();
        SpawnItem(prefab, pos);
        Invoke("spawnRandom", 1.0f);
    }

    public void SpawnItem(GameObject itemPrefab, Vector2 pos)
    {
        GameObject obj = Instantiate(itemPrefab);
        obj.transform.position = pos;
    }

}
public struct Point
{
    public int x;
    public int y;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public Vector2 GetPos()
    {
        return new Vector2(x, y);
    }
}
}