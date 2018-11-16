using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScreenController : MonoBehaviour {

    // Use this for initialization
    public GameObject back1;
    public GameObject back2;
    public GameObject back3;
    public GameObject waspIcon;
    public GameObject waspText;
    public GameObject waspShadow;
    public GameObject games;
    public GameObject gamesShadow;

    void Start () {
        StartCoroutine(LoadScreenCor());
	}
	
	// Update is called once per frame
	IEnumerator LoadScreenCor()
    {
        yield return new WaitForSeconds(0.2f);
        back1.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        back2.SetActive(true);
        waspIcon.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        back3.SetActive(true);
        waspText.SetActive(true);
        games.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        waspShadow.SetActive(true);
        gamesShadow.SetActive(true);
        yield return new WaitForSeconds(2f);
        Application.LoadLevel("MainMenu");

    }
}
