using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BrickSpeed : MonoBehaviour
{
    public float brickSpeed = 10f;
    public float destroyInterval = 3f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * brickSpeed);


        if (transform.position.z <= -12)
        {
            SpawnManager.score++;
            print("Score: " + SpawnManager.score);
            Destroy(gameObject);
        }
    }

    public void DestroyBrickParent()
    {
        Invoke("DestroyObject", destroyInterval);
    }

    private void DestroyObject()
    {
        Destroy(gameObject);
    }


}
