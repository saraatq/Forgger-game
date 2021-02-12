using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FrogController : MonoBehaviour
{


    public GameObject frog;
    public GameObject frogsBody;
    SkinnedMeshRenderer skinnedMeshRenderer;
    private int score = 0;
    [SerializeField] private Text scoreText;

    Animator anim;

    public Material blue;
    public Material balckOnRedSpot;
    public Material orangeBlackBlue;
    public Material redGreenBlack;
    public Material yellow;
    public Material yellowOnBlack;

    /* public GameObject guts;
     GameObject gutsEx;
     bool smashed = false;*/

    private void Awake()
    {
        anim = frog.GetComponent<Animator>();
        skinnedMeshRenderer = frogsBody.GetComponent<SkinnedMeshRenderer>();
    }


    public void Idle()
    {
        RootMotion();
        //  DestroyGuts();
        anim.SetTrigger("Idle");
    }

    public void Jump()
    {
        Idle();
        RootMotion();
        //DestroyGuts();
        anim.SetTrigger("Jump");
    }

    public void Crawl()
    {
        RootMotion();
        //DestroyGuts();
        anim.SetTrigger("Crawl");
    }

    public void Tongue()
    {
        RootMotion();
        // DestroyGuts();
        anim.SetTrigger("Tongue");
    }

    public void Swim()
    {
        RootMotion();
        // DestroyGuts();
        anim.SetTrigger("Swim");
    }

    public void Smashed()
    {
        RootMotion();
        // DestroyGuts();
        anim.SetTrigger("Smashed");
        Guts();
    }

    public void TurnLeft()
    {
        anim.applyRootMotion = true;
        // DestroyGuts();
        anim.SetTrigger("TurnLeft");
    }

    public void TurnRight()
    {
        anim.applyRootMotion = true;
        // DestroyGuts();
        anim.SetTrigger("TurnRight");
    }

    public void Guts()
    {
        Invoke("SpreadGuts", 0.1f);
    }

    /*  void SpreadGuts()
      {
          smashed = false;
          if (!smashed)
          {
              Instantiate(guts, frog.transform.position, frog.transform.rotation);
              smashed = true;
          }
      }*/

    void RootMotion()
    {
        if (anim.applyRootMotion)
        {
            anim.applyRootMotion = true;
        }
    }


    /* void DestroyGuts()
     {
         gutsEx = GameObject.FindGameObjectWithTag("Guts");
         if (gutsEx != null)
         {
             Destroy(gutsEx);
             smashed = false;
         }
     }*/


    public void Blue()
    {
        skinnedMeshRenderer.material = blue;
    }
    public void BalckOnRedSpot()
    {
        skinnedMeshRenderer.material = balckOnRedSpot;
    }
    public void OrangeBlackBlue()
    {
        skinnedMeshRenderer.material = orangeBlackBlue;
    }
    public void RedGreenBlack()
    {
        skinnedMeshRenderer.material = redGreenBlack;
    }
    public void Yellow()
    {
        skinnedMeshRenderer.material = yellow;
    }
    public void YellowOnBlack()
    {
        skinnedMeshRenderer.material = yellowOnBlack;
    }
    public Vector3 rotate;
    void Start()
    {
        anim.applyRootMotion = false;

    }
    public Transform player;
    public Quaternion rotatleft;
    public Quaternion rotatright;
    public Quaternion rotatup;
    public Quaternion rotatdown;
    // calls
    //public Vector3 d;
    void Update()
    {
        scoreText.text = "score: " + score;
        if (transform.position.x == 20)
        {
            SceneManager.LoadScene(7);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            score++;
            player.rotation = rotatup;
            transform.position += new Vector3(1, 0, 0);
            Jump();


        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            
            player.rotation = rotatleft;
            transform.position += new Vector3(0, 0, 1);
            Jump();


        }
        if (Input.GetKeyUp(KeyCode.D))
        {

            player.rotation = rotatright;
            transform.position += new Vector3(0, 0, -1);
            Jump();


        }
        if (Input.GetKeyUp(KeyCode.S))
        {

            player.rotation = rotatdown;
            transform.position += new Vector3(-1, 0, 0);
            Jump();


        }
        Idle();


    }
    private void OnCollisionenter(Collision collision)
    {
        if (collision.gameObject.name == "waterpath")
        {
            Debug.Log("yes");
        }
    }
}
