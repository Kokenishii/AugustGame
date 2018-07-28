using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleMovement : MonoBehaviour {
    public float lerpTime;
    public float rotateSpeed;
    Vector3 followTo;
    public Transform myPlayer;
    Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - myPlayer.position;
	}
	
	// Update is called once per frame
    void FixedUpdate () {
        followTo = new Vector3(myPlayer.position.x+offset.x, myPlayer.position.y + offset.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, followTo, lerpTime);
	}
}
