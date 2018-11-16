using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLostController : MonoBehaviour {

    // Use this for initialization
    public AlphaController AlphaController;
    public GameObject skullCarcass1;
    public GameObject skullCarcass2;
    public GameObject circleSkull;
    public GameObject circleRestart;
    public GameObject restartButton;
    public GameObject restartButton2;
    public GameObject cycleRestart2;
    public GameObject circleSkull2;
    public GameObject skullCarcass3;


    private void Awake()
    {
        restartButton = GameObject.Find("IMG_7576 (2)");
        circleRestart = GameObject.Find("IMG_7579 (2)");

        circleSkull = GameObject.Find("CycleSkull (2)");

        skullCarcass1 = GameObject.Find("IMG_7589 (2)");
        skullCarcass2 = GameObject.Find("IMG_7587 (2)");
    }
    IEnumerator AlphaCor()
    {
        
        yield return new WaitForSeconds(1f);
        restartButton2.SetActive(true);
        cycleRestart2.SetActive(true);
        circleSkull2.SetActive(true);
        skullCarcass3.SetActive(true);
    }

	void Start () {
        StartCoroutine(AlphaCor());
        restartButton.GetComponent<AlphaController>().alphaStart = true;
        circleRestart.GetComponent<AlphaController>().alphaStart = true;
        circleSkull.GetComponent<AlphaController>().alphaStart = true;
        skullCarcass1.GetComponent<AlphaController>().alphaStart = true;
        skullCarcass2.GetComponent<AlphaController>().alphaStart = true;
        
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
