using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleLight : MonoBehaviour {
    public Color newColor;
    Color defaultColor;
    public Material myMaterial;
	// Use this for initialization
	void Start () {
        defaultColor = myMaterial.color;
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.E))
        {
            myMaterial.SetColor("_EmissionColor", newColor);
        }
        else{
            myMaterial.SetColor("_EmissionColor", defaultColor);
        }
	}
}
