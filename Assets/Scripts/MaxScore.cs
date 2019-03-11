using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if(PlayerPrefs.GetInt("Record") == null)
        {
            GetComponent<Text>().text = "0";
        }
        else
        {
            GetComponent<Text>().text = PlayerPrefs.GetInt("Record").ToString();
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
