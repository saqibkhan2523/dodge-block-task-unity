using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] powerUpPrefabs;

    public GameObject brickParentPrefab;

    public float startDelay = 2f;

    public float spawnInterval = 5f;

    public float startDelayPU = 3f;

    public float spawnIntervalPU = 7f;

    public static int score;

    public static int lives = 3;

    public static int coins = 0;

    public float powerUpXRange = 9;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBricks", startDelay, spawnInterval);
        InvokeRepeating("SpawnPowerUps", startDelayPU, spawnIntervalPU);

    }

    // Update is called once per frame
    void Update()
    {
        if(lives <= 0)
        {
            CancelInvoke("SpawnBricks");
            CancelInvoke("SpawnPowerUps");
            print("Game Over");
        }
    }

    void SpawnBricks()
    {
        Instantiate(brickParentPrefab, brickParentPrefab.transform.position, brickParentPrefab.transform.rotation);
    }

    void SpawnPowerUps()
    {
        int powerUpIndex = Random.Range(0, powerUpPrefabs.Length);
        Vector3 powerUpPosition = new Vector3(Random.Range(-powerUpXRange, powerUpXRange), powerUpPrefabs[powerUpIndex].transform.position.y, powerUpPrefabs[powerUpIndex].transform.position.z);

        Instantiate(powerUpPrefabs[powerUpIndex], powerUpPosition, powerUpPrefabs[powerUpIndex].transform.rotation);


    }
}
