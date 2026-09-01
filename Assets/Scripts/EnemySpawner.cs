using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Spawner Setup")]
    public GameObject enemyPrefab; 
    GameObject[] enemyPool;
    public int enemyPoolSize = 10;

    public float spawnInterval = 2.5f;

    public Transform spawnPoint;

    [Header("Spawn Position Bounds")]
    public float minX = -6f;
    public float maxX = 6f;           // Right bound

    private float timer;

    void Start()
    {
        enemyPool = new GameObject[enemyPoolSize];

        for(int i=0; i < enemyPoolSize; i++)
        {
            enemyPool[i] = Instantiate(enemyPrefab);
            enemyPool[i].SetActive(false);
        }
    }

    void Update()
    {
        SpawnEnemy();
    }

    void SpawnEnemy()
    {
        foreach(GameObject enemy in enemyPool)
        {
            timer += Time.deltaTime;

            if (timer >= spawnInterval)
            {
                float axisY = spawnPoint.transform.position.y;
                float axisZ = spawnPoint.transform.position.z;
                float randomX = Random.Range(minX, maxX);
                Quaternion spawnQuaternion = spawnPoint.rotation;
                Vector3 spawnPosition = new Vector3(randomX, axisY, axisZ);
                enemy.SetActive(false);

                enemy.transform.position = spawnPosition;
                enemy.transform.rotation = spawnQuaternion;
                enemy.SetActive(true);
                timer = 0f;
             }
        }
    }
}   