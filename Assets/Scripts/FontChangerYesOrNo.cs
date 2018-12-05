using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FontChangerYesOrNo : MonoBehaviour {
    public FontStyle m_Yes;
    public Text m_YesText;
    public FontStyle m_No;
    public Text m_NoText;
    public StoryElement storyElement;
    public GameObject Text;
    public bool ChangeTheTutorialState=false;
    public NoTutorial TB;

    // Use this for initialization
    void Start () {
        m_Yes = FontStyle.Bold;
        m_YesText.fontStyle = m_Yes;
        m_YesText.fontSize = 40;
        m_YesText.color = Color.green;
        ChangeTheTutorialState = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Text.activeSelf == true)
        {
            ChangeFontSize();
            if (m_YesText.fontSize == 40 && Input.GetKeyDown(KeyCode.Space))
            {
                ChangeTheTutorialState = true;
                TB.changetutorial =true;

                StartCoroutine(Loading());
            }
            if (m_NoText.fontSize == 40 && Input.GetKeyDown(KeyCode.Space))
            {
                storyElement.changetutorial = true;
                SceneManager.LoadScene("SampleScene");

            }
        }

    }

    void ChangeFontSize()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            m_Yes = FontStyle.Normal;
            m_YesText.fontStyle = m_Yes;
            m_YesText.fontSize = 30;
            m_YesText.color = Color.black;
            m_No = FontStyle.Bold;
            m_NoText.fontStyle = m_No;
            m_NoText.fontSize = 40;
            m_NoText.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            m_Yes = FontStyle.Bold;
            m_YesText.fontStyle = m_Yes;
            m_YesText.fontSize = 40;
            m_YesText.color = Color.green;
            m_No = FontStyle.Normal;
            m_NoText.fontStyle = m_No;
            m_NoText.fontSize = 30;
            m_NoText.color = Color.black;
        }
    }
    IEnumerator Loading()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("LoadingScene");
    }
}
