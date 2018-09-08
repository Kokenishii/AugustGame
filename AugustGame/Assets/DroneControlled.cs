using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneControlled : MonoBehaviour {
    public Color newColor;
    Color oldColor;
    Color tempColor;
	// Use this for initialization
	void Start () {
        oldColor = gameObject.GetComponent<SpriteRenderer>().color;
        tempColor = oldColor;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.E))
        {
            //print("new");
            gameObject.GetComponent<SpriteRenderer>().color = newColor;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().color = oldColor;
        }
	}
}
