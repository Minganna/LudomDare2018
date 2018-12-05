using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    //public variable
    public Text[] Texts;
    public GameObject[] TextObject;
    //private variable
    private Queue<string> sentences;
	// Use this for initialization
	void Start () {
        sentences = new Queue<string>();
	}

    public void StartDialogue(Dialogue dialogue)
    {
        TextObject[0].SetActive(true);
        TextObject[1].SetActive(true);
        Texts[0].text = dialogue.name;
    
        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count==0)
        {
            EndDialogue();
            return;
        }
       string sentence= sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }


    public void ChangeName(Dialogue dialogue)
    {
        Texts[0].text = dialogue.name;
    }

    IEnumerator TypeSentence(string sentence)
    {
        Texts[1].text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            Texts[1].text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        TextObject[0].SetActive(false);
        TextObject[1].SetActive(false);
    }

}
