using UnityEngine;
using System.Collections;

public class ManagerEnemySpawn : MonoBehaviour
{
    [SerializeField] private Spawner[] _spawnPositions;
    [SerializeField] private float _timeSpawn;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private void CreateEnemy(Enemy enemyPrefab)
    {
        Instantiate(enemyPrefab);
    }

    private IEnumerator SpawnEnemies()
    {
        WaitForSeconds waitTime = new WaitForSeconds(_timeSpawn);

        while (enabled)
        {
            int randomIndex = Random.Range(0, _spawnPositions.Length);
            Spawner spawnPosition = _spawnPositions[randomIndex];
            Enemy prefab = spawnPosition.GetTypeEnemy();
            prefab.Init(spawnPosition);
            CreateEnemy(prefab);
            
            yield return waitTime;
        }
    }
}