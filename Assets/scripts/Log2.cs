using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log2 : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    public Vector3 move = Vector3.forward;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(0, 0, speed);
        if (this.gameObject.transform.position.z > 22)
            Destroy(this.gameObject);
    }
}
