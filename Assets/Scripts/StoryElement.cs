using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryElement : MonoBehaviour {

    private string Headcolor;
    private string Bodycolor;
    private string Uppercolor;
    private string Lowercolor;
    public string Headcolor2;
    public string Bodycolor2;
    public string Uppercolor2;
    public string Lowercolor2;
    private float randomNumber = 0;
    private bool stopcolor = false;
    private bool nolongerneededHead = false;
    private bool nolongerneededBody = false;
    private bool nolongerneededUpper = false;
    private bool nolongerneededLower = false;
    private bool AllDone = false;
    private bool ContinueExplanation = false;
    private bool BTutorialSecondPart = false;
    private bool TextFinishedDisplay = true;
    


    static public bool Tutorial = true;

    public ChangeBubble CB; 
    public bool changetutorial = true;
    public GetOtherObjectColor[] TutorialChangedColor;
    public GameOver Gameover;
    public Dialogue dialogue;
    public DialogueManager dialogueManager;
    public Player player;
    public GameObject[] chameleonParts;
    public FontChangerYesOrNo YN;
    public NoTutorial TB;
    public string[] selectedColors;
    public GameObject Text;
    public GameObject[] YesorNo;
    public bool YesorNotAppear=false;
    public WhatColorIsPlayer CP;


    void Start()
    {


        if (Tutorial == true)
        {
            dialogue.name = "Shop Assistant";
            dialogueManager.ChangeName(dialogue);
            dialogue.sentences[0] = "Use Arrow Key to move and space to interact";
            dialogue.sentences[1] = "Hello my little pinata!";
            dialogue.sentences[2] = "are you ready to learn how to amaze everyone with your Color-changing ability?";
            dialogue.sentences[3] = "Try to move yourself in front of one of these toys";
            dialogue.sentences[4] = "and press Space to change your color to match the RED TOY";

            StartCoroutine(StartTutorialExplanation());
        }
        StartCoroutine(ColorSelection());
    }



    IEnumerator ColorSelection()
    {
        yield return new WaitForSeconds(1f);
        stopcolor = true;
        nolongerneededHead = true;
        yield return new WaitForSeconds(4f);
        stopcolor = false;
        yield return new WaitForSeconds(1f);
        stopcolor = true;
        nolongerneededBody = true;
        yield return new WaitForSeconds(4f);
        stopcolor = false;
        yield return new WaitForSeconds(1f);
        stopcolor = true;
        nolongerneededUpper = true;
        yield return new WaitForSeconds(4f);
        stopcolor = false;
        yield return new WaitForSeconds(1f);
        stopcolor = true;
        nolongerneededLower = true;
        if (Tutorial == false)
        {
            StartCoroutine(StartDialogue());
        }
        else
        {
            StartTutorial();
        }


    }

    IEnumerator StartDialogue()
    {
        dialogue.name = "Miguel";
        dialogueManager.ChangeName(dialogue);
        dialogue.sentences[0] = "Mommy! I would like a pinata for my birtday!!";
        yield return new WaitForSeconds(1f);
        TriggerDialogue();
        yield return new WaitForSeconds(5f);
        CB.ChooseBubbleHead();
        dialogueManager.DisplayNextSentence();
        yield return new WaitForSeconds(5f);
        CB.ChooseBubbleBody();
        dialogueManager.DisplayNextSentence();
        yield return new WaitForSeconds(5f);
        CB.ChooseBubbleUpperTail();
        dialogueManager.DisplayNextSentence();
        yield return new WaitForSeconds(5f);
        CB.ChooseBubbleLowerTail();
        dialogueManager.DisplayNextSentence();
        yield return new WaitForSeconds(5f);
        CB.ChangeBubbleNoColor();
        if (TB.difficulties==true)
        {
            Normal();
            yield return new WaitForSeconds(5f);
            TriggerDialogue();
            yield return new WaitForSeconds(5f);
            dialogueManager.DisplayNextSentence();
            yield return new WaitForSeconds(5f);
            dialogueManager.DisplayNextSentence();
            yield return new WaitForSeconds(10f);
            dialogueManager.DisplayNextSentence();
            yield return new WaitForSeconds(10f);
        }
        Gameover.GAMEOVER();

    }

    void Update()
    {

        changetutorial = !TB.changetutorial;
        Tutorial = changetutorial;

        if (YN.ChangeTheTutorialState == true)
            {
                Tutorial = changetutorial;
            }
        if (Tutorial == true)
        {
            if (!Text.activeSelf && YesorNotAppear == true)
            {
                player.Timeplayer = 0;
                YesorNo[0].SetActive(true);
                YesorNo[1].SetActive(true);
            }
            if (!Text.activeSelf)
            {
                ContinueExplanation = true;
            }

            if (Text.activeSelf && ContinueExplanation == true)
            {
                YesorNotAppear = true;
            }
        }


    }

    void FixedUpdate()
    {
      if (Tutorial==false)
       {
            easyGame();
               
        }
      if(Tutorial==true)
        {
            if (AllDone == true)
            {
                displayNextTutorial();
            }
        }

        randColor();
       

     
        // Debug.Log("Screen Width : " + Screen.width);
        //Debug.Log("Screen heigh : " + Screen.height);
    }

    void easyGame()
    {
        if (nolongerneededHead == false)
        {
            dialogue.sentences[1] = "I would like its head to be " + Headcolor;
            selectedColors[0] = Headcolor;
        }


        if (nolongerneededBody == false)
        {
            dialogue.sentences[2] = "I would like its body to be " + Bodycolor;
            selectedColors[1] = Bodycolor;
        }

        if (nolongerneededUpper == false)
        {
            dialogue.sentences[3] = "I would like its tail to be " + Uppercolor;
            selectedColors[2] = Uppercolor;
        }

        if (nolongerneededLower == false)
        {
            dialogue.sentences[4] = "I would like the tip of the tail to be " + Lowercolor;
            selectedColors[3] = Lowercolor;
        }
    }

    void Normal()
    {
        if (nolongerneededHead == false)
        {
            dialogue.sentences[1] = "Head: " + Headcolor;
            selectedColors[0] = Headcolor;
        }


        if (nolongerneededBody == false)
        {
            dialogue.sentences[2] = "Body: " + Bodycolor;
            selectedColors[1] = Bodycolor;
        }

        if (nolongerneededUpper == false)
        {
            dialogue.sentences[3] = "FirstHalfTail: " + Uppercolor;
            selectedColors[2] = Uppercolor;
        }

        if (nolongerneededLower == false)
        {
            dialogue.sentences[4] = "LowerHalfTail: " + Lowercolor;
            selectedColors[3] = Lowercolor;
        }
        secondChoice();
       dialogue.sentences[0] = Headcolor2;
       dialogue.sentences[1] = Bodycolor2;
       dialogue.sentences[2] = Uppercolor2;
       dialogue.sentences[3] = Lowercolor2;



    }


   void  secondChoice()
    {
        if (CP.head == 0)
        {
            Headcolor2 = "I don't also mind Head Red";
        }
        if (CP.head == 1)
        {
           Headcolor2 = "I don't also mind Head Pink";
        }
        if (CP.head == 2)
        {
            Headcolor2 = "I don't also mind Head: Green";
        }
        if (CP.head == 3)
        {
            Headcolor2 = "I don't also mind Head Yellow";
        }
        if (CP.head == 4)
        {
            Headcolor2 = "I don't also mind Head Blue";
        }
        if (CP.body == 0)
        {
           Bodycolor2 = "I don't also mind body Red";
        }
        if (CP.body == 1)
        {
            Bodycolor2 = "I don't also mind body Pink";
        }
        if (CP.body == 2)
        {
            Bodycolor2 = "I don't also mind body Green";
        }
        if (CP.body == 3)
        {
            Bodycolor2 = "I don't also mind body Yellow";
        }
        if (CP.body == 4)
        {
            Bodycolor2 = "I don't also mind body Blue";
        }
        if (CP.uppertail == 0)
        {
            Uppercolor2 = "I don't also mind tail Red";
        }
        if (CP.uppertail == 1)
        {
            Uppercolor2 = "I don't also mind tail Pink";
        }
        if (CP.uppertail == 2)
        {
            Uppercolor2 = "I don't also mind tail Green";
        }
        if (CP.uppertail == 3)
        {
            Uppercolor2 = "I don't also mind tail Yellow";
        }
        if (CP.uppertail == 4)
        {
            Uppercolor2 = "I don't also mind tail Blue";
        }
        if (CP.lowertail == 0)
        {
            Lowercolor2 = "I don't also mind the tip of his tail Red";
        }
        if (CP.lowertail == 1)
        {
            Lowercolor2 = "I don't also mind the tip of his tail Pink";
        }
        if (CP.lowertail == 2)
        {
            Lowercolor2 = "I don't also mind the tip of his tail: Green";
        }
        if (CP.lowertail == 3)
        {
            Lowercolor2 = "I don't also mind the tip of his tail Yellow";
        }
        if (CP.lowertail == 4)
        {
            Lowercolor2 = "I don't also mind the tip of his tail Blue";
        }

    }


IEnumerator WaitForText()
    {
        yield return new WaitForSeconds(1f);
        dialogueManager.DisplayNextSentence();
        TextFinishedDisplay = true;
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
     
    }

    void randColor()
    {
        

        if (stopcolor == false)
        {
            randomNumber = Random.Range(0.0f, 1.0f);

            if (randomNumber <= 1.0f && randomNumber >= 0.8f)
            {
                if(nolongerneededHead == false)
                { 
                Headcolor = "RED";
                }
                if (nolongerneededBody == false)
                {
                    Bodycolor = "RED";
                }
                if (nolongerneededUpper==false)
                {
                    Uppercolor = "RED";
                }
                if (nolongerneededLower == false)
                {
                    Lowercolor = "RED";
                }



            }
            if (randomNumber <= 0.8f && randomNumber >= 0.6f)
            {
                if (nolongerneededHead == false)
                {
                    Headcolor = "blue";
                }
                if (nolongerneededBody == false)
                {
                    Bodycolor = "blue";
                }
                if (nolongerneededUpper == false)
                {
                    Uppercolor = "blue";
                }
                if (nolongerneededLower == false)
                {
                    Lowercolor = "blue";
                }
            }
            if (randomNumber <= 0.6f && randomNumber >= 0.4f)
            {
                if (nolongerneededHead == false)
                {
                    Headcolor = "green";
                }
                if (nolongerneededBody == false)
                {
                    Bodycolor = "green";
                }
                if (nolongerneededUpper == false)
                {
                    Uppercolor = "green";
                }
                if (nolongerneededLower == false)
                {
                    Lowercolor = "green";
                }
            }
            if (randomNumber <= 0.4f && randomNumber >= 0.2f)
            {
                if (nolongerneededHead == false)
                {
                    Headcolor = "yellow";
                }
                if (nolongerneededBody == false)
                {
                    Bodycolor = "yellow";
                }
                if (nolongerneededUpper == false)
                {
                    Uppercolor = "yellow";
                }
                if (nolongerneededLower == false)
                {
                    Lowercolor = "yellow";
                }
            }
            if (randomNumber <= 0.2f && randomNumber >= 0.0f)
            {
                if (nolongerneededHead == false)
                {
                    Headcolor = "pink";
                }
                if (nolongerneededBody == false)
                {
                    Bodycolor = "pink";
                }
                if (nolongerneededUpper == false)
                {
                    Uppercolor = "pink";
                }
                if (nolongerneededLower == false)
                {
                    Lowercolor = "pink";
                }
            }
        }
    }

    //Tutorial Parts
    void StartTutorial()
    {
        dialogueManager.DisplayNextSentence();
        AllDone = true;


    }
    IEnumerator StartTutorialExplanation()
    {
        yield return new WaitForSeconds(1f);
        TriggerDialogue();

    }
    IEnumerator TutorialSecondPart()
    {
        BTutorialSecondPart = true;
        TriggerDialogue();
        yield return new WaitForSeconds(1f);

    }
    void displayNextTutorial()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (TextFinishedDisplay == true)
            {
                TextFinishedDisplay = false;
                StartCoroutine(WaitForText());
            }

        }
        if (ContinueExplanation == true)
        {

            if (TutorialChangedColor[2].itchangedcolor == true)
            {
                dialogue.sentences[0] = "Good Job my Boy!!!!!";
                dialogue.sentences[1] = "You can color most of your body parts!";
                dialogue.sentences[2] = "Head, Body and tail,";
                dialogue.sentences[3] = "Now that you learned the basics......";
                dialogue.sentences[4] = "would you like to start to play?";
                if (BTutorialSecondPart == false)
                {
                    StartCoroutine(TutorialSecondPart());
                }
            }
        }
    }



}
