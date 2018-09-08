using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneAnimation : MonoBehaviour {
    public float speed;
    int direction = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += direction *  new Vector3(speed * Time.deltaTime, 0, 0);
        if(transform.position.x <= -45)
        {
            direction = 1;
        }
        else if (transform.position.x >= 7)
        {
            direction = -1;
        }
	}
}
