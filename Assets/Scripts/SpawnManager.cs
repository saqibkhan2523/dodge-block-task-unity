using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject player;

    public GameObject brickParentPrefab;

    public float startDelay = 2f;

    public float spawnInterval = 5f;

    public static int score;

    public static int lives = 3;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBricks", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if(lives <= 0)
        {
            CancelInvoke("SpawnBricks");
            print("Game Over");
        }
    }

    void SpawnBricks()
    {
        Instantiate(brickParentPrefab, brickParentPrefab.transform.position, brickParentPrefab.transform.rotation);
    }
}
