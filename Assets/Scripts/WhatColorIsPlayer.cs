using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatColorIsPlayer : MonoBehaviour {

    public ChameleonChangeColor[] partscolor;

    private float ColorredHead;
    private float ColorGreenHead;
    private float ColorBlueHead;
    private float ColoralphaHead;
    private float ColorredBody;
    private float ColorGreenBody;
    private float ColorBlueBody;
    private float ColoralphaBody;
    private float ColorredUpperTail;
    private float ColorGreenUpperTail;
    private float ColorBlueUpperTail;
    private float ColoralphaUpperTail;
    private float ColorredLowerTail;
    private float ColorGreenLowerTail;
    private float ColorBlueLowerTail;
    private float ColoralphaLowerTail;


    public int head;
    public int body;
    public int uppertail;
    public int lowertail;




    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ColorHead();
        ColorBody();
        UpperTail();
        LowerTail();
    }


    void ColorHead()
    {
        ColorredHead = partscolor[0].Colorred;
        ColorGreenHead = partscolor[0].ColorGreen;
        ColorBlueHead = partscolor[0].ColorBlue;
        ColoralphaHead = partscolor[0].Coloralpha;
        if (ColorredHead == 1.00000 && ColorGreenHead == 0.00000 && ColorBlueHead == 0.00000 && ColoralphaHead == 1.00000)
        {
            Debug.Log("Head Is Red");
            head = 0;
        }
        if (ColorredHead == 1.00000 && ColorGreenHead == 0.00000 && ColorBlueHead == 1.00000 && ColoralphaHead == 1.00000)
        {
            Debug.Log("Head Is Pink");
            head = 1;
        }

        if (ColorredHead == 0.00000 && ColorGreenHead == 1.00000 && ColorBlueHead == 0.00000 && ColoralphaHead == 1.00000)
        {
            Debug.Log("Head Is Green");
            head = 2;
        }
        if (ColorredHead == 1.00000 && ColorGreenHead == 1.00000 && ColorBlueHead == 0.00000 && ColoralphaHead == 1.00000)
        {
            Debug.Log("Head Is Yellow");
            head = 3;
        }

        if (ColorredHead == 0.00000 && ColorGreenHead == 0.00000 && ColorBlueHead == 1.00000 && ColoralphaHead == 1.00000)
        {
            Debug.Log("Head Is Blue");
            head = 4;
        }
    }
    void ColorBody()
    {
        ColorredBody = partscolor[1].Colorred;
        ColorGreenBody = partscolor[1].ColorGreen;
        ColorBlueBody = partscolor[1].ColorBlue;
        ColoralphaBody = partscolor[1].Coloralpha;
        if (ColorredBody == 1.00000 && ColorGreenBody == 0.00000 && ColorBlueBody == 0.00000 && ColoralphaBody == 1.00000)
        {
            Debug.Log("Body Is Red");
            body = 0;
        }
        if (ColorredBody == 1.00000 && ColorGreenBody == 0.00000 && ColorBlueBody == 1.00000 && ColoralphaBody == 1.00000)
        {
            Debug.Log("Body Is Pink");
            body = 1;
        }

        if (ColorredBody == 0.00000 && ColorGreenBody == 1.00000 && ColorBlueBody == 0.00000 && ColoralphaBody == 1.00000)
        {
            Debug.Log("Body Is Green");
            body = 2;
        }
        if (ColorredBody == 1.00000 && ColorGreenBody == 1.00000 && ColorBlueBody == 0.00000 && ColoralphaBody == 1.00000)
        {
            Debug.Log("Body Is Yellow");
            body = 3;
        }

        if (ColorredBody == 0.00000 && ColorGreenBody == 0.00000 && ColorBlueBody == 1.00000 && ColoralphaBody == 1.00000)
        {
            Debug.Log("Body Is Blue");
            body = 4;
        }
    }
    void UpperTail()
    {
        ColorredUpperTail = partscolor[2].Colorred;
        ColorGreenUpperTail = partscolor[2].ColorGreen;
        ColorBlueUpperTail = partscolor[2].ColorBlue;
        ColoralphaUpperTail= partscolor[2].Coloralpha;
        if (ColorredUpperTail == 1.00000 && ColorGreenUpperTail == 0.00000 && ColorBlueUpperTail == 0.00000 && ColoralphaUpperTail == 1.00000)
        {
            Debug.Log("UpperTail Is Red");
            uppertail = 0;
        }
        if (ColorredUpperTail == 1.00000 && ColorGreenUpperTail == 0.00000 && ColorBlueUpperTail == 1.00000 && ColoralphaUpperTail == 1.00000)
        {
            Debug.Log("UpperTail Is Pink");
            uppertail = 1;
        }

        if (ColorredUpperTail == 0.00000 && ColorGreenUpperTail == 1.00000 && ColorBlueUpperTail == 0.00000 && ColoralphaUpperTail == 1.00000)
        {
            Debug.Log("UpperTail Is Green");
            uppertail = 2;
        }
        if (ColorredUpperTail == 1.00000 && ColorGreenUpperTail == 1.00000 && ColorBlueUpperTail == 0.00000 && ColoralphaUpperTail == 1.00000)
        {
            Debug.Log("UpperTail Is Yellow");
            uppertail = 3;
        }

        if (ColorredUpperTail == 0.00000 && ColorGreenUpperTail == 0.00000 && ColorBlueUpperTail == 1.00000 && ColoralphaUpperTail == 1.00000)
        {
            Debug.Log("UpperTail Is Blue");
            uppertail = 4;
        }
    }
    void LowerTail()
    {
        ColorredLowerTail = partscolor[3].Colorred;
        ColorGreenLowerTail = partscolor[3].ColorGreen;
        ColorBlueLowerTail = partscolor[3].ColorBlue;
        ColoralphaLowerTail = partscolor[3].Coloralpha;
        if (ColorredLowerTail == 1.00000 && ColorGreenLowerTail == 0.00000 && ColorBlueLowerTail == 0.00000 && ColoralphaLowerTail == 1.00000)
        {
            Debug.Log("LowerTail Is Red");
            lowertail = 0;
        }
        if (ColorredLowerTail == 1.00000 && ColorGreenLowerTail == 0.00000 && ColorBlueLowerTail == 1.00000 && ColoralphaLowerTail == 1.00000)
        {
            Debug.Log("LowerTail Is Pink");
            lowertail = 1;
        }

        if (ColorredLowerTail == 0.00000 && ColorGreenLowerTail == 1.00000 && ColorBlueLowerTail == 0.00000 && ColoralphaLowerTail == 1.00000)
        {
            Debug.Log("LowerTail Is Green");
            lowertail = 2;
        }
        if (ColorredLowerTail == 1.00000 && ColorGreenLowerTail == 1.00000 && ColorBlueLowerTail == 0.00000 && ColoralphaLowerTail == 1.00000)
        {
            Debug.Log("LowerTail Is Yellow");
            lowertail = 3;
        }

        if (ColorredLowerTail == 0.00000 && ColorGreenLowerTail == 0.00000 && ColorBlueLowerTail == 1.00000 && ColoralphaLowerTail == 1.00000)
        {
            Debug.Log("LowerTail Is Blue");
            lowertail = 4;
        }
    }
}
