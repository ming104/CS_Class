using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnPoints;
    [SerializeField] private GameObject[] enemies;
    private readonly float _enemyGenerationTime = 1f;
    private float _currentTime;

    private void Start()
    {
        // Debug.LogFormat("LogFormat test {0}{1}{2}",8,6,5);
    }
    void Update()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime > _enemyGenerationTime)
        {
            var enemyIndex = UnityEngine.Random.Range(0, enemies.Length);
            var spawnIndex = UnityEngine.Random.Range(0, spawnPoints.Length);
            GameObject enemyObj = Instantiate(enemies[enemyIndex]) as GameObject;
            enemyObj.transform.position = spawnPoints[spawnIndex].transform.position;
            enemyObj.GetComponent<Enemy>().Move();
            _currentTime = 0f;
        }
    }
}
