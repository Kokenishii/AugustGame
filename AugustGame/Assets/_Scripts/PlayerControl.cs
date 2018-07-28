﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    Rigidbody2D rbPlayer;
    Vector2 move;
    public float jumpForce;
    public float moveSpeed = 1f;
    //public LayerMask groundLayers;
    //public Transform checkGround;
    public bool isGrounded;
    bool facingRight=true;
	// Use this for initialization
	void Start () {
        rbPlayer = gameObject.GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        move = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rbPlayer.velocity.y);
        rbPlayer.velocity = move;

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rbPlayer.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
        if ((move.x > 0 && !facingRight)||(move.x<0 && facingRight) )
        {
            flip();
        }

	}
    void flip()
    {
        facingRight = !facingRight;
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y,transform.localScale.z);
    }
}
