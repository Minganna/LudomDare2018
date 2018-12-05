using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetOtherObjectColor : MonoBehaviour {

    public Renderer Headrend;
    public Renderer Bodyrend;
    public Renderer UpperTailRend;
    public Renderer LowerTailRend;
    public GameObject Head;
    public GameObject Body;
    public GameObject UpperTail;
    public GameObject LowerTail;
    public int Charging;
    public SliderChange slider;
    public string Headtxet = "";
    public string BodyText = "";
    public string UpperTailText = "";
    public string LowerTailText = "";
    public bool itchangedcolor=false;



    private KeyCode Key=KeyCode.Space;
    private Color32 ToyColor;
    private bool getkeyposition;
    private bool headparts;
    private bool bodyparts;
    private bool UpperTailparts;
    private bool LowerTailparts;



    // Use this for initialization
    void Start () {
        Headrend = Head.GetComponent<Renderer>();
        Bodyrend = Body.GetComponent<Renderer>();
        UpperTailRend = UpperTail.GetComponent<Renderer>();
        LowerTailRend = LowerTail.GetComponent<Renderer>();
        ToyColor = gameObject.GetComponent<SpriteRenderer>().color;

    }
	
	// Update is called once per frame
	void Update () {
        if( Input.GetKeyDown(Key))
        {
            getkeyposition = true;

        }
        else if(Input.GetKeyUp(Key))
        {
            getkeyposition = false;
            slider.SiderDisappear();
            Charging = 0;
            Headtxet = "";BodyText = "";UpperTailText = "";LowerTailText = "";
        }

        if(getkeyposition==true)
        {
            slider.SlideAppear();
            if (headparts == true)
        {
            if (Charging < 20)
            {
              slider.fHeadText();
              Headtxet = "Head";
              Charging += 1;
              itchangedcolor = false;
            }
            if (Charging == 20)
            {
                Headrend.material.color = ToyColor;
                    itchangedcolor = true;
                    
            }
        }
            if (bodyparts == true)
            {
                if (Charging < 20)
                {
                    slider.fBodyText();
                    BodyText = "Body";
                    Charging += 1;
                    itchangedcolor = false;
                }
                if (Charging == 20)
                {
                    Bodyrend.material.color = ToyColor;
                    itchangedcolor = true;
                }
            }
            if (UpperTailparts == true)
            {
                if (Charging < 20)
                {
                    slider.fUpperText();
                    UpperTailText = "UpperTail";
                    Charging += 1;
                    itchangedcolor = false;
                }
                if (Charging == 20)
                {
                    UpperTailRend.material.color = ToyColor;
                    itchangedcolor = true;
                }
            }
            if (LowerTailparts == true)
            {
                if (Charging < 20)
                {
                    slider.fLowerText();
                    LowerTailText = "LowerTail";
                    Charging += 1;
                    itchangedcolor = false;
                }
                if (Charging == 20)
                {
                    LowerTailRend.material.color = ToyColor;
                    itchangedcolor = true;
                }
            }
        }

    }

    void OnTriggerStay2D(Collider2D col)
    {
        
        if (col.gameObject.tag == "Head" )
        {
            headparts = true; 
        }
        if (col.gameObject.tag == "Body")
        {
            bodyparts = true;
        }
        if (col.gameObject.tag == "UpperTail")
        {
            UpperTailparts = true;
        }
        if (col.gameObject.tag == "LowerTail")
        {
            LowerTailparts = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {

        headparts = false;
        bodyparts = false;
        UpperTailparts = false;
        LowerTailparts = false;
    }

}
