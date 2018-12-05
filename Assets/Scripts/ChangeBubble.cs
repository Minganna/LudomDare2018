using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBubble : MonoBehaviour {
    public Sprite[] BubbleSprite;
    public GameObject Sprite;
    public SpriteRenderer Sprtr;
    public GameOver GM;




    // Use this for initialization
    public void ChangeBubbleNoColor()
    {
        Sprtr.sprite = BubbleSprite[0];
    }
    public void ChangeBubbleYellow()
    {
        Sprtr.sprite =BubbleSprite[3];
    }
    public void ChangeBubbleGreen()
    {
        Sprtr.sprite = BubbleSprite[2];
    }
    public void ChangeBubbleBlue()
    {
        Sprtr.sprite = BubbleSprite[4];
    }

    public void ChangeBubblePink()
    {
        Sprtr.sprite = BubbleSprite[5];
    }

    public void ChangeBubbleRed()
    {
        Sprtr.sprite = BubbleSprite[1];
    }

    public void ChooseBubbleHead()
    {
        if(GM.head==0)
        {
            ChangeBubbleRed();
        }
        if (GM.head == 4)
        {
            ChangeBubbleBlue();
        }
        if (GM.head == 2)
        {
            ChangeBubbleGreen();
        }
        if (GM.head == 3)
        {
            ChangeBubbleYellow();
        }
        if (GM.head == 1)
        {
            ChangeBubblePink();
        }


    }
    public void ChooseBubbleBody()
    {
        if (GM.body == 0)
        {
            ChangeBubbleRed();
        }
        if (GM.body == 4)
        {
            ChangeBubbleBlue();
        }
        if (GM.body == 2)
        {
            ChangeBubbleGreen();
        }
        if (GM.body == 3)
        {
            ChangeBubbleYellow();
        }
        if (GM.body == 1)
        {
            ChangeBubblePink();
        }
    }
    public void ChooseBubbleUpperTail()
    {
        if (GM.uppertail == 0)
        {
            ChangeBubbleRed();
        }
        if (GM.uppertail == 4)
        {
            ChangeBubbleBlue();
        }
        if (GM.uppertail == 2)
        {
            ChangeBubbleGreen();
        }
        if (GM.uppertail == 3)
        {
            ChangeBubbleYellow();
        }
        if (GM.uppertail == 1)
        {
            ChangeBubblePink();
        }
    }
    public void ChooseBubbleLowerTail()
    {
        if (GM.lowertail == 0)
        {
            ChangeBubbleRed();
        }
        if (GM.lowertail == 4)
        {
            ChangeBubbleBlue();
        }
        if (GM.lowertail == 2)
        {
            ChangeBubbleGreen();
        }
        if (GM.lowertail == 3)
        {
            ChangeBubbleYellow();
        }
        if (GM.lowertail == 1)
        {
            ChangeBubblePink();
        }


    }
}



   