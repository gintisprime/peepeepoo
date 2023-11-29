using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cham_control : MonoBehaviour
{
    Rigidbody2D rb;
    public float acc = 10;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity += new Vector2(Input.GetAxis("Horizontal") * acc * Time.fixedDeltaTime, 
            Input.GetAxis("Vertical") * acc * Time.fixedDeltaTime);
    }
}
