using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terraingenerator : MonoBehaviour
{
    private int maxTerrian = 50;
    private int begin = 1, cntr = 0;
    [SerializeField] private List<GameObject> terrains = new List<GameObject>();
    private List<GameObject> currentTerrains = new List<GameObject>();
    private Vector3 currentposition = new Vector3(0, 0, 0);

    private void drawterrian()
    {
        GameObject terrain;
        if (begin < 6 || begin % 10 == 0)
        {
            terrain = Instantiate(terrains[0], currentposition, Quaternion.identity);
        }
        else
        {
            terrain = Instantiate(terrains[Random.Range(1, terrains.Count)], currentposition, Quaternion.identity);
        }
        currentTerrains.Add(terrain);
        if (currentTerrains.Count > maxTerrian * 3)
        {
            Destroy(currentTerrains[0]);
            currentTerrains.RemoveAt(0);
        }
        currentposition.x++;
        begin++;
    }
    void Start()
    {
        for (int i = 0; i < maxTerrian; i++)
        {
            drawterrian();

        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            drawterrian();
        }
    }
}

