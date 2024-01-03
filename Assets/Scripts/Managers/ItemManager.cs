using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public Point[] Points =
    {
        new Point(0, 0), new Point(1, 1), new Point(1, -1), new Point(-1, 1), new Point(-1, -1),
        new Point(2, 2), new Point(2, -2), new Point(-2, 2), new Point(-2, -2), new Point(3, 3),
        new Point(3, -3), new Point(-3, 3), new Point(-3, -3),   
    };

    public GameObject[] itemPrefabs = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandom();
    }
    public void SpawnItem(GameObject itemPrefab, Vector2 pos)
    {
        GameObject obj = Instantiate(itemPrefab) as GameObject;
        obj.transform.position = pos;
    }

    public void SpawnRandom()
    {
        GameObject prefab = itemPrefabs[Random.Range(0, itemPrefabs.Length)];
        Vector2 pos = Points[Random.Range(0, Points.Length)].GetPos();
        SpawnItem(prefab, pos);
        Invoke("SpawnRandom", 1.0f);
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