using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChameleonChangeColor : MonoBehaviour {

    private Renderer rend;
    private Color Color;
    private float startingchanges;
    private Vector4 YellowColor;
    public float Colorred;
    public float ColorGreen;
    public float ColorBlue;
    public float Coloralpha;
    

    // Use this for initialization
    void Start()
    {
        rend=GetComponent<Renderer>();
        startingchanges= Random.Range(0.0f, 1.0f);
        YellowColor = new Vector4(1.00000f, 1.00000f, 0.00000f, 1.00000f);

        Color = Color.white;
        GetColor();

    }

    // Update is called once per frame
    void Update () {
        {
            Colorred=rend.material.color.r;
            ColorGreen=rend.material.color.g;
            ColorBlue=rend.material.color.b;
            Coloralpha=rend.material.color.a;
        }
     
       
    }

    void GetColor()
    {
        
        if(startingchanges <= 1.0f && startingchanges >= 0.8f)
        {
            Color = Color.red;
            rend.material.color = Color;
        }
        if (startingchanges <= 0.8f && startingchanges >= 0.6f)
        {
            Color = Color.blue;
            rend.material.color = Color;
        }
        if (startingchanges <= 0.6f && startingchanges >= 0.4f)
        {
            Color = Color.green;
            rend.material.color = Color;
        }
        if (startingchanges <= 0.4f && startingchanges >= 0.2f)
        {
            Color = YellowColor;
            rend.material.color = Color;
        }
        if (startingchanges <= 0.2f && startingchanges >= 0.0f)
        {
            Color = Color.magenta;
            rend.material.color = Color;
        }

    }
}
