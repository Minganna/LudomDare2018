using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderChange : MonoBehaviour {
    public GameObject Slider;
    public Slider ChangeColor;
    public GetOtherObjectColor[] Getit;
    public Player player;
    public Text TextChangeColor;
    public GameObject TextColorObJ;


    private int whichone = 0;
    private string Headtxet = "";
    private string BodyText = "";
    private string UpperTailText = "";
    private string LowerTailText = "";


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        TextChangeColor.text = "Changing: " + Headtxet + " " + BodyText + " " + UpperTailText + " " + LowerTailText;
        whichone = player.whichone;

        if (whichone == 0)
        {
            ChangeColor.value = Getit[0].Charging;
        }
        else if (whichone == 1)
        {
            ChangeColor.value = Getit[1].Charging;
        }
        else if (whichone == 3)
        {
            ChangeColor.value = Getit[2].Charging;
        }
        else if (whichone == 2)
        {
            ChangeColor.value = Getit[3].Charging;
        }
        else if (whichone == 4)
        {
            ChangeColor.value = Getit[4].Charging;
        }
    }

    public void SiderDisappear()
    {
        Slider.SetActive(false);
        Headtxet = ""; BodyText = ""; UpperTailText = ""; LowerTailText = "";
        TextColorObJ.SetActive(false);
    }
    public void SlideAppear()
    {
        Slider.SetActive(true);
        TextColorObJ.SetActive(true);

    }
    public void fHeadText()
    {
        if (whichone == 0)
        {
            Headtxet = Getit[0].Headtxet;
        }
        if (whichone == 1)
        {
            Headtxet = Getit[1].Headtxet;
        }
        if (whichone == 3)
        {
            Headtxet = Getit[2].Headtxet;
        }
        if (whichone == 2)
        {
            Headtxet = Getit[3].Headtxet;
        }
        if (whichone == 4)
        {
            Headtxet = Getit[4].Headtxet;
        }
    }
    public void fBodyText()
    {
        if (whichone == 0)
        {
            BodyText = Getit[0].BodyText;
        }
        if (whichone == 1)
        {
            BodyText = Getit[1].BodyText;
        }
        if (whichone == 3)
        {
            BodyText = Getit[2].BodyText;
        }
        if (whichone == 2)
        {
            BodyText = Getit[3].BodyText;
        }
        if (whichone == 4)
        {
            BodyText = Getit[4].BodyText;
        }
    }
    public void fUpperText()
    {
        if (whichone == 0)
        {
            UpperTailText = Getit[0].UpperTailText;
        }
        if (whichone == 1)
        {
            UpperTailText = Getit[1].UpperTailText;
        }
        if (whichone == 3)
        {
            UpperTailText = Getit[2].UpperTailText;
        }
        if (whichone == 2)
        {
            UpperTailText = Getit[3].UpperTailText;
        }
        if (whichone == 4)
        {
            UpperTailText = Getit[4].UpperTailText;
        }
    }
    public void fLowerText()
    {
        if (whichone == 0)
        {
            LowerTailText = Getit[0].LowerTailText;
        }
        if (whichone == 1)
        {
            LowerTailText = Getit[1].LowerTailText;
        }
        if (whichone == 3)
        {
            LowerTailText = Getit[2].LowerTailText;
        }
        if (whichone == 2)
        {
            LowerTailText = Getit[3].LowerTailText;
        }
        if (whichone == 4)
        {
            LowerTailText = Getit[4].LowerTailText;
        }
    }


}
