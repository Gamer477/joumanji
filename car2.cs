using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car2 : MonoBehaviour {

    // Use this for initialization
    public Vector3 teleportPoint;
    public Rigidbody rb;
    private Vector3 speed = new Vector3(-21f, 0, 38.5f);

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (rb.position.x <= 21)
            rb.MovePosition(transform.position + transform.right * Time.deltaTime * 4);
        else
            //rb.AddForce(12,0,-4);
            rb.MovePosition(speed);
        //transform.positio;
    }
}
