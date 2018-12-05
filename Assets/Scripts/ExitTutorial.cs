using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitTutorial : MonoBehaviour {
    public GameObject[] Explanation;
    public GameObject[] Picture;


    // Use this for initialization
    void Start () {
        StartCoroutine(StartExplain());
    }
    IEnumerator StartExplain()
    {
        yield return new WaitForSeconds(2f);
        Picture[0].SetActive(false);
        Explanation[0].SetActive(false);
        yield return new WaitForSeconds(1f);
        Picture[1].SetActive(true);
        Explanation[1].SetActive(true);
        yield return new WaitForSeconds(2f);
        Picture[1].SetActive(false);
        Explanation[1].SetActive(false);
        yield return new WaitForSeconds(1f);
        Picture[2].SetActive(true);
        Explanation[2].SetActive(true);
        yield return new WaitForSeconds(2f);
        Picture[2].SetActive(false);
        Explanation[2].SetActive(false);
        yield return new WaitForSeconds(1f);
        Picture[3].SetActive(true);
        Explanation[3].SetActive(true);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("SampleScene");

    }



}
