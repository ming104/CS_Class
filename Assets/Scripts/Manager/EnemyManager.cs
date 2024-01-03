using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ming10{
public class EnemyManager : MonoBehaviour
{
    [Header("Enemy Prefab List")]
    public GameObject[] EnemyPrefabs;

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

    // Start is called before the first frame update
    void Start()
    {
        //SpawnRandom();
    }

    public void SpawnRandom()
    {
        GameObject prefab = EnemyPrefabs[Random.Range(0, EnemyPrefabs.Length)];
        Vector2 pos = Points[Random.Range(0, Points.Length)].GetPos();
        SpawnEnemy(prefab, pos);
        Invoke("SpawnRandom", 1f);
    }

    public void SpawnEnemy(GameObject EnemyPrefab, Vector3 _pos)
    {
        GameObject enemy = Instantiate(EnemyPrefab);
        enemy.transform.position = _pos;
        enemy.GetComponent<Enemy>().Move();
    }
}
}