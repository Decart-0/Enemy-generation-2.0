using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints;
    [SerializeField] private float _timeSpawn;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private void CreateEnemy()
    {
        int randomIndex = Random.Range(0, _spawnPoints.Length);
        SpawnPoint spawnPoint = _spawnPoints[randomIndex];
        Enemy enemy = spawnPoint.TypeEnemy;

        enemy.Init(spawnPoint.TargetEnemy);
        Instantiate(enemy, spawnPoint.transform.position, Quaternion.identity);
    }

    private IEnumerator SpawnEnemies()
    {
        WaitForSeconds waitTime = new WaitForSeconds(_timeSpawn);

        while (enabled)
        {          
            CreateEnemy();
            
            yield return waitTime;
        }
    }
}