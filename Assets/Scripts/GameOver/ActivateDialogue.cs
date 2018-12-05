using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateDialogue : MonoBehaviour {
    public Dialogue dialogue;
    public DialogueManager dialogueManager;
    public Text MiguelText;
    public FontStyle FontTextMiguel;
    public GameObject[] Texts;
    public GameObject beating;
    public GameObject Background;
    public GameObject Chameleon;
    public Rigidbody2D HeadRigidbody;
    public Rigidbody2D[] TailsRB;
    public GameObject Death;
    public GameObject DeathSprite;

    // Use this for initialization
    void Start () {
        dialogue.sentences[0] = "This piñata is perfect!!!!!";
        dialogue.sentences[1] = "Me and my friend will have soooo much fun with you...";
        dialogue.sentences[2] = "To get the candies....";
        dialogue.sentences[3] = "A Sacrifice must be made";
        dialogue.sentences[4] = "Why are you looking at me like that?";
        dialogue.sentences[5] = "I never said that you had to follow that kid instruction.... did I?";
        StartCoroutine(DialogueGameOver());
        
	}
	
    IEnumerator DialogueGameOver()
    {
        yield return new WaitForSeconds(1f);
        TriggerDialogue();
        yield return new WaitForSeconds(5f);
        dialogueManager.DisplayNextSentence();
        yield return new WaitForSeconds(5f);
        dialogueManager.DisplayNextSentence();
        yield return new WaitForSeconds(5f);
        FontTextMiguel = FontStyle.Bold;
        MiguelText.fontStyle = FontTextMiguel;
        MiguelText.color = Color.red;
        MiguelText.fontSize = 40;
        dialogueManager.DisplayNextSentence();
        yield return new WaitForSeconds(5f);
        Texts[0].SetActive(false);
        Texts[1].SetActive(false);
        Background.SetActive(false);
        beating.SetActive(true);
        yield return new WaitForSeconds(2f);
        beating.SetActive(false);
        Chameleon.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        HeadRigidbody.gravityScale = 1;
        yield return new WaitForSeconds(1f);
        TailsRB[0].gravityScale = 1;
        yield return new WaitForSeconds(0.5f);
        TailsRB[1].gravityScale = 1;
        yield return new WaitForSeconds(2f);
        Chameleon.SetActive(false);
        Death.SetActive(true);
        DeathSprite.SetActive(true);
        dialogue.name = "Shop Keeper";
        dialogueManager.ChangeName(dialogue);
        dialogueManager.DisplayNextSentence();
        Texts[0].SetActive(true);
        Texts[1].SetActive(true);
        FontTextMiguel = FontStyle.Normal;
        MiguelText.fontStyle = FontTextMiguel;
        MiguelText.color = Color.white;
        MiguelText.fontSize = 30;
        yield return new WaitForSeconds(3f);
        dialogueManager.DisplayNextSentence();









    }

    public void TriggerDialogue()
    {

        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

    }
}
