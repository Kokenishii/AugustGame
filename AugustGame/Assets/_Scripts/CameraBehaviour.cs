using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour {
    public Transform myPlayer;
    public float lerpTime;
    Vector3 followTo;
    float offsetY;
	// Use this for initialization
	void Start () {
        offsetY = transform.position.y - myPlayer.position.y;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        followTo = new Vector3(myPlayer.position.x, myPlayer.position.y+offsetY, transform.position.z);

        transform.position = Vector3.Lerp(transform.position, followTo, lerpTime);
	}
}
