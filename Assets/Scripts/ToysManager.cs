using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToysManager : MonoBehaviour {
    public float randomNumber;
    public GameObject[] Toys;
    public Collider2D[] ToysCollider;

	// Use this for initialization
	void Start () {
        randomNumber = Random.Range(0.0f, 1.0f);
        DecideToys();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void DecideToys()
    {

        if (randomNumber <= 1.0f && randomNumber >= 0.8f)
        {
            Toys[0].SetActive(true);
            ToysCollider[0].enabled=true;
            Toys[1].SetActive(true);
            ToysCollider[1].enabled = true;
            Toys[2].SetActive(true);
            ToysCollider[2].enabled = true;
            Toys[3].SetActive(true);
            ToysCollider[3].enabled = true;
            Toys[4].SetActive(true);
            ToysCollider[4].enabled = true;
        }
        if (randomNumber <= 0.8f && randomNumber >= 0.6f)
        {
            Toys[5].SetActive(true);
            ToysCollider[5].enabled = true;
            Toys[6].SetActive(true);
            ToysCollider[6].enabled = true;
            Toys[7].SetActive(true);
            ToysCollider[7].enabled = true;
            Toys[8].SetActive(true);
            ToysCollider[8].enabled = true;
            Toys[9].SetActive(true);
            ToysCollider[9].enabled = true;
        }
        if (randomNumber <= 0.6f && randomNumber >= 0.4f)
        {
            Toys[10].SetActive(true);
            ToysCollider[10].enabled = true;
            Toys[11].SetActive(true);
            ToysCollider[11].enabled = true;
            Toys[12].SetActive(true);
            ToysCollider[12].enabled = true;
            Toys[13].SetActive(true);
            ToysCollider[13].enabled = true;
            Toys[14].SetActive(true);
            ToysCollider[14].enabled = true;
        }
        if (randomNumber <= 0.4f && randomNumber >= 0.2f)
        {
            Toys[0].SetActive(true);
            ToysCollider[0].enabled = true;
            Toys[6].SetActive(true);
            ToysCollider[6].enabled = true;
            Toys[2].SetActive(true);
            ToysCollider[2].enabled = true;
            Toys[8].SetActive(true);
            ToysCollider[8].enabled = true;
            Toys[14].SetActive(true);
            ToysCollider[14].enabled = true;
        }
        if (randomNumber <= 0.2f && randomNumber >= 0.0f)
        {
            Toys[5].SetActive(true);
            ToysCollider[5].enabled = true;
            Toys[6].SetActive(true);
            ToysCollider[6].enabled = true;
            Toys[2].SetActive(true);
            ToysCollider[2].enabled = true;
            Toys[8].SetActive(true);
            ToysCollider[8].enabled = true;
            Toys[14].SetActive(true);
            ToysCollider[14].enabled = true;

        }
    }
}
    

