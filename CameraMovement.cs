using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraMovement : MonoBehaviour
{
    private Transform lookAt;
    private Vector3 startOffset;
    private Vector3 moveVector;
    // Use this for initialization
    void Start()
    {
        lookAt = GameObject.FindGameObjectWithTag("Player").transform;
        startOffset = transform.position - lookAt.position;
    }
    // Update is called once per frame
    void Update()
    {
        moveVector = Vector3.zero;
        moveVector = lookAt.position + startOffset;
        // X value
       // moveVector.x = 0;
        moveVector.y = 1.74f;
        transform.position = moveVector;
    }
}
