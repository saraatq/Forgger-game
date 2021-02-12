using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawner : MonoBehaviour
{

    public GameObject Car;
    public Transform spawnPos; // created an empty object in the unity called spawn position having the start position just to determine where the car spawn
    public float minSeparationTime;
    public float maxSeparationTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnCar()); // to activate the spawn function in the start of the game 
    }


    private IEnumerator spawnCar()
    {
        while (true) //to make the cars spawn continiously not only one time at the begining of the game 
        {
            yield return new WaitForSeconds(Random.Range(minSeparationTime, maxSeparationTime));  // to make a difference between the spawned cars in the same lane
            Instantiate(Car, spawnPos.position, Quaternion.Euler(-90, 0, 0)); //creates a new car object at the begining of the road
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
