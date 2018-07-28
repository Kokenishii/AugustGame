using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
	{
        //print("collision detected");
        if(collision.gameObject.CompareTag("ground"))	
        {
            GetComponentInParent<PlayerControl>().isGrounded = true;
        }
	}
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            GetComponentInParent<PlayerControl>().isGrounded = false;
        }
    }
}
