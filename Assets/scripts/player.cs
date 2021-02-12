using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class player : MonoBehaviour
{
    public static Stack<float> checkpoint = new Stack<float>();
    public GameObject playerPos;
    private float temp;
    private Animator animator;
    private bool isHopping;
    private int back = 0;
    
    public Transform playerPosition;
    public static player instance;

    void Start()
    {
        instance = this;
        checkpoint.Push(0);
        animator = GetComponent<Animator>();
        temp = playerPos.transform.position.x;
    }
    /*void FixedUpdate()
    {
        frame++;
        if (frame > 60 && transform.position.x > 2)
        {
            
            frame = 0;
        }
    }*/
    void Update()
    {
        if (checkpoint.Peek() != playerPosition.position.x && playerPosition.position.x % 10 == 0)
            checkpoint.Push(playerPosition.position.x);


        
        

    }

    private void MovePlayer(Vector3 vee)
    {
        animator.SetTrigger("hop");
        isHopping = true;
        transform.position = transform.position + vee;
    }

    public void FinishHop()
    {
        isHopping = false;
    }
    
    private void OnCollisionEner(Collision collision)
    {
        if (collision.gameObject.name == "road")
            Debug.Log("collide");
    }

}
