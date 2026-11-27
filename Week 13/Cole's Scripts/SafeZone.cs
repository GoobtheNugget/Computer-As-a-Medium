using UnityEngine;

public class SafeZone : MonoBehaviour
{
    public SpawnEnemy enemySpawner;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            enemySpawner.isSpawning = false;
        }
    }
}
