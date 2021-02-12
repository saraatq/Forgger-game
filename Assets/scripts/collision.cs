using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
    public GameObject plr;
    public static Stack<float> stk = new Stack<float>();
    public GameObject playerPos;
    private float temp, t;
    private int cntr = 0;

    private void Start()
    {
        stk.Push(3);
    }

    private void Update()
    {
        temp = playerPos.transform.position.x;
        if (temp % 10 == 0 && stk.Peek() != temp)
        {
            stk.Push(temp);
        }
    }

    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Guts")
        {
            t = stk.Peek();
            //playerPos.transform.position = new Vector3(t, 0 , 0);
            //plr.transform.position = new Vector3(t, 0, 0);
            Destroy(collisioninfo.gameObject);
            //cntr++;
            //Instantiate(plr, new Vector3(t, 0, 0), Quaternion.Euler(0, 180, 0));
                SceneManager.LoadScene(4);
            
        }
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
