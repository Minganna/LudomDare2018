using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climbing : MonoBehaviour {
   public Rigidbody2D rb;


    public bool hitladders;
    public bool hitladders2;
    public bool hitladders3;
    public float maxX;
    public float minX;
    public Vector3 CurrentPosition;



    // Update is called once per frame
    void Update () {
        CurrentPosition = rb.transform.position;
     CurrentPosition.x=   Mathf.Clamp(rb.transform.position.x, minX, maxX);
        rb.transform.position = CurrentPosition;

        if (hitladders == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.transform.position = new Vector2(rb.position.x, 0.4f);

            }
        }
        if (hitladders2 == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.transform.position = new Vector2(rb.position.x, 2.31f);

            }
        }
        if (hitladders3 == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.transform.position = new Vector2(rb.position.x, 4.17f);

            }
        }
        if (hitladders == true)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rb.transform.position = new Vector2(rb.position.x, -1.81f);

            }
        }
        if (hitladders2 == true)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rb.transform.position = new Vector2(rb.position.x, 0.4f);

            }
        }
        if (hitladders3 == true)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rb.transform.position = new Vector2(rb.position.x, 2.31f);

            }
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ladders")
        {
            hitladders = true;
        }
        if (other.gameObject.tag == "Ladders2")
        {
            hitladders2 = true;
        }
        if (other.gameObject.tag == "Ladders3")
        {
            hitladders3 = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ladders")
        {
            hitladders = false;
        }
        if (other.gameObject.tag == "Ladders2")
        {
            hitladders2 = false;
        }
        if (other.gameObject.tag == "Ladders3")
        {
            hitladders3 = false;
        }

    }

}
