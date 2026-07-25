using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;

    void Start()
    {
        Debug.Log("Spawner Started");
        InvokeRepeating(nameof(SpawnPipe), 1f, spawnRate);
    }

    void SpawnPipe()
    {
        Debug.Log("Spawning Pipe");

        float randomY = Random.Range(-1f, 1f);

        GameObject pipe = Instantiate(
            pipePrefab,
            new Vector3(10, randomY, 0),
            Quaternion.identity
        );

        Debug.Log("Created: " + pipe.name);
    }
}