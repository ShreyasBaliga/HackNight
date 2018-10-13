  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementScript : MonoBehaviour {
    private Animator animator;
    public int lane;
    private CharacterController controller;

    void Start () {
       lane = 0;
       animator = GetComponent<Animator>();
       controller = GetComponent<CharacterController>();

    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
                animator.SetBool("jumpping", true);
                Invoke("stopJumping", 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetBool("sliding", true);
            Invoke("stopSliding", 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (lane == 0 || lane==1)
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
        newPosition.x= Mathf.MoveTowards(newPosition.x, lane, 50.0f * Time.deltaTime);
        //transform.position = newPosition;
        controller.Move(Vector3.forward * Time.deltaTime);

    }
    void stopJumping()
    {
        animator.SetBool("jumpping", false);
    }
    void stopSliding()
    {
        animator.SetBool("sliding", false);
    }
}
