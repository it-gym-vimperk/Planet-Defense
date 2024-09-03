using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float InitialSpawnDelay = 0f;
    public float MaxSpawDelay = 1.0f;
    public float MinSpawnDelay = 0.4f;
    public float SpawnDelayDecrease = 0.01f;
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(InitialSpawnDelay);
        while (true)
        {
            SpawnPrefab();
            MaxSpawDelay -= SpawnDelayDecrease;
            if (MaxSpawDelay < MinSpawnDelay)
            {
                MaxSpawDelay = MinSpawnDelay;
            }
            yield return new WaitForSeconds(MaxSpawDelay);
        }
    }
    
    private void SpawnPrefab()
    {
        Instantiate(prefabToSpawn);
    }
}
