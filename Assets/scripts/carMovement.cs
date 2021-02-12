using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    public Vector3 move = Vector3.back;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        moveChar(move);
        if (this.gameObject.transform.position.z > 22)
            Destroy(this.gameObject);
    }

    // Update is called once per frame


    void moveChar(Vector3 direction)
    {
        rb.velocity = direction * speed;
    }

    


}
