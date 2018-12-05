using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
    public WhatColorIsPlayer whatcolor;
    public StoryElement kidcolor;
    public NoTutorial NT;

    public int head;
    public int body;
    public int uppertail;
    public int lowertail;
    public int head2;
    public int body2;
    public int uppertail2;
    public int lowertail2;

    private bool headthesame;
    private bool bodythesame;
    private bool uppertailthesame;
    private bool lowertailthesame;

    // Use this for initialization
    void Start () {
		
	}

    public void GAMEOVER()
    {

   if(head==whatcolor.head)
        {
            headthesame = true;
        }
   if(body==whatcolor.body)
        {
            bodythesame = true;
        }
   if(uppertail==whatcolor.uppertail)
        {
            uppertailthesame = true;
        }
   if(lowertail==whatcolor.lowertail)
        {
            lowertailthesame = true;
        }
   if (NT.difficulties == true)
        {
            if (head2 == whatcolor.head)
            {
                headthesame = true;
            }
            if (body2 == whatcolor.body)
            {
                bodythesame = true;
            }
            if (uppertail2 == whatcolor.uppertail)
            {
                uppertailthesame = true;
            }
            if (lowertail2 == whatcolor.lowertail)
            {
                lowertailthesame = true;
            }
        }

            CheckResult();

    }

    void CheckResult()
    {
        if (NT.difficulties == true)
        {
            if (headthesame && bodythesame || uppertailthesame && lowertailthesame || uppertailthesame && bodythesame || headthesame && lowertailthesame)
            {
                SceneManager.LoadScene("GameOver");
            }
            else
            {
                SceneManager.LoadScene("VictoryScreen");
            }
        }
        else
        {
            if (headthesame && bodythesame && uppertailthesame && lowertailthesame)
            {
                SceneManager.LoadScene("GameOver");
            }
            else
            {
                SceneManager.LoadScene("VictoryScreen");
            }
        }
    }
	
	// Update is called once per frame
	void Update () {

        checkhead();
        checkBody();
        checkUpperTail();
        LowerTail();
        SecondColor();

    }

    void checkhead()
    {
            if (kidcolor.selectedColors[0] == "RED")
            {
                head = 0;
            }
            else if (kidcolor.selectedColors[0] == "blue")
            {
                head = 4;
            }
            else if (kidcolor.selectedColors[0] == "green")
            {
                head = 2;
            }
            else if (kidcolor.selectedColors[0] == "yellow")
            {
                head = 3;
            }
            else if (kidcolor.selectedColors[0] == "pink")
            {
                head = 1;
            }


    }
    void checkBody()
    {
        if (kidcolor.selectedColors[1] == "RED")
        {
            body = 0;
        }
        else if (kidcolor.selectedColors[1] == "blue")
        {
            body = 4;
        }
        else if (kidcolor.selectedColors[1] == "green")
        {
            body = 2;
        }
        else if (kidcolor.selectedColors[1] == "yellow")
        {
            body = 3;
        }
        else if (kidcolor.selectedColors[1] == "pink")
        {
            body = 1;
        }
    }

    void checkUpperTail()
    {
        if (kidcolor.selectedColors[2] == "RED")
        {
            uppertail = 0;
        }
        else if (kidcolor.selectedColors[2] == "blue")
        {
            uppertail = 4;
        }
        else if (kidcolor.selectedColors[2] == "green")
        {
            uppertail = 2;
        }
        else if (kidcolor.selectedColors[2] == "yellow")
        {
            uppertail = 3;
        }
        else if (kidcolor.selectedColors[2] == "pink")
        {
            uppertail = 1;
        }
    }
    void LowerTail()
    {
        if (kidcolor.selectedColors[3] == "RED")
        {
            lowertail = 0;
        }
        else if (kidcolor.selectedColors[3] == "blue")
        {
            lowertail = 4;
        }
        else if (kidcolor.selectedColors[3] == "green")
        {
           lowertail = 2;
        }
        else if (kidcolor.selectedColors[3] == "yellow")
        {
            lowertail = 3;
        }
        else if (kidcolor.selectedColors[3] == "pink")
        {
            lowertail = 1;
        }
    }
    public void SecondColor()
    {
        if (kidcolor.Headcolor2 == "I don't also mind Head: Red")
        {
            head2 = 0;
        }
        if (kidcolor.Headcolor2 == "I don't also mind Head: Pink")
        {
            head2 = 1;
        }
        if (kidcolor.Headcolor2 == "I don't also mind Head: Green")
        {
           head2 = 2;
        }
        if (kidcolor.Headcolor2 == "I don't also mind Head: Yellow")
        {
            head2 = 3;
        }
        if (kidcolor.Headcolor2 == "I don't also mind Head: Blue")
        {
         head2 = 4;
        }
        if (kidcolor.Bodycolor2 == "I don't also mind body: Red")
        {
            body2 = 0;
        }
        if (kidcolor.Bodycolor2 == "I don't also mind body: Pink")
        {

            body2 = 1;
        }
        if (kidcolor.Bodycolor2 == "I don't also mind body: Green")
        {
            body2 = 2;
        }
        if (kidcolor.Bodycolor2 == "I don't also mind body: Yellow")
        {
            body2 = 3;
        }
        if (kidcolor.Bodycolor2 == "I don't also mind body: Blue")
        {
            body2 = 4;
        }
        if (kidcolor.Uppercolor2 == "I don't also mind UpperTail: Red")
        {

            uppertail2 = 0;
        }
        if (kidcolor.Uppercolor2 == "I don't also mind UpperTail: Pink")
        {

            uppertail2 = 1;
        }
        if (kidcolor.Uppercolor2 == "I don't also mind UpperTail: Green")
        {
            uppertail2 = 2;
        }
        if (kidcolor.Uppercolor2 == "I don't also mind UpperTail: Yellow")
        {

            uppertail2 = 3;
        }
        if (kidcolor.Uppercolor2 == "I don't also mind UpperTail: Blue")
        {
            uppertail2 = 4;
        }
        if (kidcolor.Lowercolor2 == "I don't also mind LowerTail: Red")
        {
            lowertail2 = 0;
        }
        if (kidcolor.Lowercolor2 == "I don't also mind LowerTail: Pink")
        {

            lowertail2 = 1;
        }
        if (kidcolor.Lowercolor2 == "I don't also mind LowerTail: Green")
        {

            lowertail2 = 2;
        }
        if (kidcolor.Lowercolor2 == "I don't also mind LowerTail: Yellow")
        {
            lowertail2 = 3;
        }
        if (kidcolor.Lowercolor2 == "I don't also mind LowerTail: Blue")
        {

            lowertail2 = 4;
        }
    }
}
