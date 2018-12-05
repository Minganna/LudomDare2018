using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public CharacterController2D controller;
	public Animator animator;
	public float Timeplayer=1f;
    public int whichone;
    float HorizontalMove = 0f;
    public float runSpeed = 40f;
  

 


    void Start()
    {

    }

	// Update is called once per frame
	void Update () {

        if (Timeplayer == 1)
           
        {
            HorizontalMove = Input.GetAxisRaw("Horizontal")*runSpeed;
       
          animator.SetFloat("Speed", Mathf.Abs(HorizontalMove));
       }

    }

    void FixedUpdate()
    {
        if(Timeplayer==0)
       {
           controller.Move(0, false, false);
     animator.SetFloat("Speed", 0);
     }
       else if (Timeplayer == 1)
        {
            controller.Move(HorizontalMove * Time.fixedDeltaTime,false,false);
           
       }
  
    }


    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Blue")
        {
            whichone = 0;
        }
        if (col.gameObject.tag == "Green")
        {
            whichone = 1;
        }
        if (col.gameObject.tag == "Pink")
        {
            whichone = 2;
        }
        if (col.gameObject.tag == "Red")
        {
            whichone = 3;
        }
        if (col.gameObject.tag == "Yellow")
        {
            whichone = 4;
        }
    }

    }