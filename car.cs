using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    /*float m_XValue=15;
    string xString;
    Vector3 m_NewPosition;
  
    // Update is called once per frame
    void Update()
    {
        
        m_XValue = m_NewPosition.x;
        if (m_XValue < 1f)
        {
            //m_NewPosition.x = 13.954f;
            transform.position = new Vector3(18f, 0, 42f);
            //transform.Translate(Vector3.right * Time.deltaTime * 3);
        }
        else
        {
            transform.Translate(Vector3.right * Time.deltaTime * 3);
           
             
        }
        
        
        
    }*/
    
    public Vector3 teleportPoint;
    public Rigidbody rb;
    private Vector3 speed = new Vector3(21f, 0, 44f);

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (rb.position.x >= -20)
            rb.MovePosition(transform.position + transform.right * Time.deltaTime * 4);
        else
            //rb.AddForce(12,0,-4);
            rb.MovePosition(speed);
            //transform.positio;
    }


}
