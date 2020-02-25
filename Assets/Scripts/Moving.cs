﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{


 
    public float speed;
    public float jumpSpeed;
    private bool onGround;
    public Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;

    // Update is called once per frame

    void Start()
    {


        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }


    void Update()
    {



        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed, 0f, 0f) * Time.deltaTime;



        }

        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-speed, 0f, 0f) * Time.deltaTime;



        }

        

        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (onGround)
            {
                rigidbody2d.AddForce(new Vector2(0f, jumpSpeed), ForceMode2D.Impulse);

                onGround = false;
               
            }
        }


    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            if (collision.transform.position.y < transform.position.y)
            {
              
                onGround = true;
            }
        }
    }

}

