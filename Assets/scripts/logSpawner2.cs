using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logSpawner2 : MonoBehaviour
{
    public GameObject Log;
    public Transform LogSpawnPos, waterpath; // created an empty object in the unity called spawn position having the start position just to determine where the car spawn
    public float minSeparationTime;
    public float maxSeparationTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnCar()); // to activate the spawn function in the start of the game 
    }


    private IEnumerator spawnCar()
    {
        if (waterpath.position.x % 2 == 0)
            while (true) //to make the cars spawn continiously not only one time at the begining of the game 
            {
                yield return new WaitForSeconds(Random.Range(minSeparationTime, maxSeparationTime));  // to make a difference between the spawned cars in the same lane
                Instantiate(Log, LogSpawnPos.position, Quaternion.Euler(0, 180, 0)); //creates a new car object at the begining of the road
            }

    }
}
