﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyLittleBird : MonoBehaviour
{
    public float upVelocity = 1;
    public float directionalVelocity = 1;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            // Jump
            rb.velocity = (Vector2.up * upVelocity) + (Vector2.right * directionalVelocity);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "RightWall")
        {
            directionalVelocity = -directionalVelocity;
        }
        else if (collision.gameObject.tag == "LeftWall")
        {
            directionalVelocity = -directionalVelocity;
        }
    }
}
