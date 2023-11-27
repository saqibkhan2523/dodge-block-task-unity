using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpMoveBackward : MonoBehaviour
{
    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * movementSpeed);

        if(transform.position.z < -10f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(gameObject.tag == "Coin")
            {
                SpawnManager.coins++;
                print("Coins: " + SpawnManager.coins);
                Destroy(gameObject);
            }
            if (gameObject.tag == "Life")
            {
                SpawnManager.lives++;
                print("Lives: " + SpawnManager.lives);
                Destroy(gameObject);
            }
        }
    }
}
