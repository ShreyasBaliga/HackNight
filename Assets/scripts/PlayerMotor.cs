using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {
    private CharacterController controller;
    private float speed = 5.0f;
    public int lane;


    // Use this for initialization
    void Start () {
        controller = GetComponent<CharacterController>();
        lane = 0;

    }

	// Update is called once per frame
	void Update () {
        controller.Move((Vector3.forward * speed) * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (lane == 0 || lane == 1)
            {
                lane--;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (lane == 0 || lane == -1)
            {
                lane++;
            }
        }
        Vector3 newPosition = transform.position;
        //newPosition.x = lane;
        newPosition.x= Mathf.MoveTowards(newPosition.x, lane, 1.5f * Time.deltaTime);
        transform.position = newPosition;
	}
}
