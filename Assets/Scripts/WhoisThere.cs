using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhoisThere : MonoBehaviour {

    public NoTutorial TT;
    public GameObject[] People;

	// Use this for initialization
	void Start () {
        if (TT.changetutorial == true)
        {
            People[0].SetActive(false);
            People[1].SetActive(true);
        }

	}
	
	// Update is called once per frame
	void Update () {

		
	}

}
