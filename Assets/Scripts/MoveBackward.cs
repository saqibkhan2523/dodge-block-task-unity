using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackward : MonoBehaviour
{
    public BrickSpeed brickSpeedScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.back * Time.deltaTime * brickSpeedScript.brickSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            brickSpeedScript.brickSpeed = 1f;
            brickSpeedScript.DestroyBrickParent();
            SpawnManager.lives -= 1;
            print("Lives: " + SpawnManager.lives);
            
        }
    }

    
}
