using UnityEngine;

public class PlantsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] plants;
    private float spawnTime = 2f;
    private GameObject player;
    private Vector3 lastSpawnPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player");
        lastSpawnPosition = player.transform.position;
        InvokeRepeating("SpawnPlants", 0f, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnPlants()
    {
        Vector3 playerPosition = player.transform.position;
        if (Vector3.Distance(lastSpawnPosition, playerPosition) > 1f) // Adjust the distance threshold as needed
        {
            int plantIndex = Random.Range(0, plants.Length);
            Instantiate(plants[plantIndex], playerPosition, plants[plantIndex].transform.rotation);
            lastSpawnPosition = playerPosition;
        }
    }
}
