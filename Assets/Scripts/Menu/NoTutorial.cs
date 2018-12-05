using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoTutorial : MonoBehaviour {

    static public bool Tutorial = false;
    static public bool diffulties = false;
    public bool changetutorial = false;
    public bool difficulties = false;

    // Use this for initialization
    void Start () {
        changetutorial = Tutorial;
        difficulties = diffulties;
    }
	
	// Update is called once per frame
	void Update () {
        Tutorial = changetutorial;
        diffulties = difficulties;


	}
}
