using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour {
    int coinCounter;
	// Use this for initialization
	void Start () {
        coinCounter = 0;
        Debug.Log("Start");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnContollerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log ("OnContollerColliderHit" + hit.gameObject.name);
        Destroy(hit.gameObject);
        coinCounter++;
        //Debug.Log("Cointer counter " + coinCounter);
    }

    void OnCollisionEnter(Collision hit)
    {
        Debug.Log("OnCollisionEnter" + hit.gameObject.name);
    }

    void OnTriggerEnter(Collision hit)
    {
        Debug.Log("OnTriggerEnter" + hit.gameObject.name);
    }
}
