using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    public int uiIndex;
    public GameObject thisUI;
    bool isTriggered = false;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
       
        if(isTriggered)
        {
            
            if (
               Input.GetKey(KeyCode.E)
               && thisUI != null)
            {
                //print("UIManager:Triggered")；
                thisUI.SetActive(true);

            }
        }
           
	}

private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            isTriggered = true;

        }
     
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isTriggered = false;
            StartCoroutine(UIdead());
        }
    }




    IEnumerator UIdead()
    {
        yield return new WaitForSeconds(1f);
        thisUI.SetActive(false);
    }

}
