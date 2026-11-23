using System.Collections;
using UnityEngine;

public class SpawnMedkit : MonoBehaviour
{
    public GameObject MedkitPrefab;
    public float spawnRangeX;
    public float spawnRangeY;

    public bool isSpawning = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnMedkitNow());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnMedkitNow()
    {
        while (isSpawning == true)
        {
            Spawn();
            yield return new WaitForSeconds(3f);
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        float randomY = Random.Range(-spawnRangeY, spawnRangeY);

        Vector3 spawnPosition = transform.position + new Vector3(randomX, randomY, 0f);

        Destroy(Instantiate(MedkitPrefab, spawnPosition, Quaternion.identity), 5f);
    }
}
