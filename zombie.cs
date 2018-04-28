using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour {
    //public Vector3 teleportPoint;
    public Rigidbody rb;
    private Transform lookAt;
    private Vector3 startOffset;
    private Vector3 moveVector;
    void Start () {
        rb = GetComponent<Rigidbody>();
        lookAt = GameObject.FindGameObjectWithTag("Player").transform;
       // startOffset = transform.position - lookAt.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.position.z >= lookAt.position.z)
            rb.MovePosition(transform.position + transform.forward * Time.deltaTime * 4);

        else
        {
            //moveVector = Vector3.zero;
            moveVector.z = lookAt.position.z + 20.0f;
            if (lookAt.position.x > -5.3 && lookAt.position.x < 4.98)
                moveVector.x = lookAt.position.x;
           
            moveVector.y = 0f;
            transform.position = moveVector;
        }
    }
}
