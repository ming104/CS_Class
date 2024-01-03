using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] EnemyPrefabs;

    public Point[] Points =
    {
        new Point(-3, -5), new Point(-3, -3), new Point(-3, -1), new Point(-3, 1), new Point(-3, 3),
        new Point(-3, 5), new Point(3, -5), new Point(3, -3), new Point(3, -1), new Point(3, 1), 
        new Point(3, 3), new Point(3, 5),
    };

    void Start()
    {
        SpawnRandom();
    }
    private void SpawnEnemy(GameObject prefab, Vector3 position)
    {
        GameObject enemy = Instantiate(prefab) as GameObject;
        prefab.transform.position = position;
        enemy.GetComponent<Enemy>().Move();
    }

    public void SpawnRandom()
    {
        GameObject prefab = EnemyPrefabs[Random.Range(0, EnemyPrefabs.Length)];
        Vector2 pos = Points[Random.Range(0, Points.Length)].GetPos();
        SpawnEnemy(prefab, pos);
        Invoke("SpawnRandom", 1f);
    }
}