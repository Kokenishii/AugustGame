using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DroneAttack : MonoBehaviour {
    public float droneAttackSeconds = 0.2f;
    public bool isAttacking = false;
    public bool isWorking = true;
    public GameObject triangle;
    SpriteRenderer mySprite;
	// Use this for initialization
	void Start () {
        isAttacking = false;
	}
	
	// Update is called once per frame
	void Update () {
        if(isAttacking)
        {
          
            Scene thisScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(thisScene.name);
        }
        if(!isWorking)
        {
            StartCoroutine(BackToWork());
        }
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player")&&!Input.GetKey(KeyCode.E))
        {
            triangle.SetActive(true);
            StartCoroutine(ToAttack());
        }
    }

    IEnumerator ToAttack()
    {
        yield return new WaitForSeconds(droneAttackSeconds);
        isAttacking = true;

    }

    IEnumerator BackToWork()
    {
        yield return new WaitForSeconds(3);
        isWorking = true;

    }
}
