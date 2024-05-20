using System.Collections;
using UnityEngine;

public class EnemySpawner2D : MonoBehaviour
{
    public GameObject enemyPrefab; 
    public Transform player; 
    public float spawnInterval = 5f; 
    public int numberOfEnemies = 3; 
    public float spawnDistance = 20f; 

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            for (int i = 0; i < numberOfEnemies; i++)
            {
                Vector2 spawnPosition = GetSpawnPosition();
                Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
            }
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private Vector2 GetSpawnPosition()
    {
        Vector2 spawnPosition;
        do
        {
            Vector2 randomDirection = Random.insideUnitCircle.normalized;
            spawnPosition = (Vector2)player.position + randomDirection * spawnDistance;
        } while (Vector2.Distance(spawnPosition, player.position) < spawnDistance);

        return spawnPosition;
    }
}