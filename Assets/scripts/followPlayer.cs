using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offset;
   
    private void Start()
    {
        transform.position = player.transform.position + offset;
    }

   
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
