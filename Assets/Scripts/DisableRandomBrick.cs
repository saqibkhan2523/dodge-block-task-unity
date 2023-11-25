using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableRandomBrick : MonoBehaviour
{
    public GameObject[] brickPrefabs;

    int brickIndex = 0;

    

    // Start is called before the first frame update
    void Start()
    {
        brickIndex = Random.Range(0, brickPrefabs.Length);
        brickPrefabs[brickIndex].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }


}
