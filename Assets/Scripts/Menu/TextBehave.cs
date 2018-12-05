using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextBehave : MonoBehaviour {
    public FontStyle m_Play;
    public Text m_PlayText;
    public FontStyle m_Exit;
    public Text m_ExitText;
    public FontStyle m_Easy;
    public Text m_EasyText;
    public FontStyle m_Normal;
    public Text m_NormalText;
    public FontStyle m_TY;
    public Text m_TYText;
    public FontStyle m_TN;
    public Text m_TNText;

    public Animator TextDancingPlay;
    public Animator TextDangingExit;
    public Animator EasyDancing;
    public Animator NormalDancing;
    public Animator TYDancing;
    public Animator TNDancing;

    public bool ChangeTheTutorialState = false;
    public NoTutorial Notut;


    public int Difficulties;

    private int Choice=1;
    public GameObject[] texts;

    // Use this for initialization
    void Start () {
        m_Play = FontStyle.Bold;
        m_PlayText.fontStyle = m_Play;
        m_PlayText.fontSize = 40;
        m_PlayText.color = Color.green;
        TextDancingPlay.SetBool("TextDancing", true);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Notut.changetutorial);
        if (texts[0].activeSelf)
        {
            DanceText();
        }
        if (texts[2].activeSelf)
        {
            DifficultyDanceText();
        }
        if (texts[4].activeSelf)
        {
            TDAncing();
        }

        if (Input.GetKeyDown(KeyCode.Space) && Choice == 1)
        {
            if (texts[0].activeSelf)
            {
                m_Easy = FontStyle.Bold;
                m_EasyText.fontStyle = m_Easy;
                m_EasyText.fontSize = 40;
                m_EasyText.color = Color.green;
                EasyDancing.SetBool("TextDancing", true);
                texts[0].SetActive(false);
                texts[1].SetActive(false);
                texts[2].SetActive(true);
                texts[3].SetActive(true);
                return;
            }
            if (texts[2].activeSelf)
            {
                m_TY = FontStyle.Bold;
                m_TYText.fontStyle = m_Easy;
                m_TYText.fontSize = 40;
                m_TYText.color = Color.green;
                TYDancing.SetBool("TextDancing", true);
                texts[2].SetActive(false);
                texts[3].SetActive(false);
                texts[4].SetActive(true);
                texts[5].SetActive(true);
                Difficulties = 0;
                Notut.difficulties = false;
                return;
            }
            if (texts[4].activeSelf&&Choice==1)
            {
                ChangeTheTutorialState = false;
                Notut.changetutorial = false;
                StartCoroutine(Loading());
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && Choice == 0)
        {
            if (texts[0].activeSelf)
            {
                Application.Quit();
            }
            if (texts[2].activeSelf)
            {
                m_TY = FontStyle.Bold;
                m_TYText.fontStyle = m_Easy;
                m_TYText.fontSize = 40;
                m_TYText.color = Color.green;
                TYDancing.SetBool("TextDancing", true);
                texts[2].SetActive(false);
                texts[3].SetActive(false);
                texts[4].SetActive(true);
                texts[5].SetActive(true);
                Choice = 1;
                Difficulties = 1;
                Notut.difficulties =  true;
                return;
            }
            if (texts[4].activeSelf && Choice == 0)
            {
                ChangeTheTutorialState = true;
                Notut.changetutorial = true;
                StartCoroutine(Loading());
            }

        }
    }


    void DanceText()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            m_Exit = FontStyle.Bold;
            m_ExitText.fontStyle = m_Exit;
            m_ExitText.fontSize = 40;
            m_ExitText.color = Color.red;
            TextDangingExit.SetBool("TextDancing", true);
            m_Play = FontStyle.Normal;
            m_PlayText.fontStyle = m_Play;
            m_PlayText.fontSize = 30;
            m_PlayText.color = Color.black;
            TextDancingPlay.SetBool("TextDancing", false);
            Choice = 0;

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            m_Exit = FontStyle.Normal;
            m_ExitText.fontStyle = m_Exit;
            m_ExitText.fontSize = 30;
            m_ExitText.color = Color.black;
            TextDangingExit.SetBool("TextDancing", false);
            m_Play = FontStyle.Bold;
            m_PlayText.fontStyle = m_Play;
            m_PlayText.fontSize = 40;
            m_PlayText.color = Color.green;
            TextDancingPlay.SetBool("TextDancing", true);
            Choice = 1;
        }
    }

    void DifficultyDanceText()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            m_Normal = FontStyle.Bold;
            m_NormalText.fontStyle = m_Normal;
            m_NormalText.fontSize = 40;
            m_NormalText.color = Color.red;
            NormalDancing.SetBool("TextDancing", true);
            m_Easy = FontStyle.Normal;
            m_EasyText.fontStyle = m_Easy;
            m_EasyText.fontSize = 30;
            m_EasyText.color = Color.black;
            EasyDancing.SetBool("TextDancing", false);
            Choice = 0;

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            m_Normal = FontStyle.Normal;
            m_NormalText.fontStyle = m_Normal;
            m_NormalText.fontSize = 30;
            m_NormalText.color = Color.black;
            NormalDancing.SetBool("TextDancing", false);
            m_Easy = FontStyle.Bold;
            m_EasyText.fontStyle = m_Easy;
            m_EasyText.fontSize = 40;
            m_EasyText.color = Color.green;
            EasyDancing.SetBool("TextDancing", true);
            Choice = 1;
        }
    }
    void TDAncing()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            m_TN = FontStyle.Bold;
            m_TNText.fontStyle = m_Normal;
            m_TNText.fontSize = 40;
            m_TNText.color = Color.red;
            TNDancing.SetBool("TextDancing", true);
            m_TY = FontStyle.Normal;
            m_TYText.fontStyle = m_Easy;
            m_TYText.fontSize = 30;
            m_TYText.color = Color.black;
            TYDancing.SetBool("TextDancing", false);
            Choice = 0;

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            m_TN = FontStyle.Normal;
            m_TNText.fontStyle = m_Normal;
            m_TNText.fontSize = 30;
            m_TNText.color = Color.black;
            TNDancing.SetBool("TextDancing", false);
            m_TY = FontStyle.Bold;
            m_TYText.fontStyle = m_Easy;
            m_TYText.fontSize = 40;
            m_TYText.color = Color.green;
            TYDancing.SetBool("TextDancing", true);
            Choice = 1;
        }
    }

    IEnumerator Loading()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("SampleScene");
    }
}
