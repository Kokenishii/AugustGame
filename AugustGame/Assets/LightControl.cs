using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour {
    public float adjustSpeed;
    Light myLight;
	// Use this for initialization
	void Start () {
        myLight = gameObject.GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        //print(lightIntensity);
        //lightIntensity += adjustSpeed * Input.GetAxis("Horizontal");
        myLight.intensity += adjustSpeed * Input.GetAxis("Vertical");
	}
}
