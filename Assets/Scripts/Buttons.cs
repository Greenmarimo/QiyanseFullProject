using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

    public GameObject next;
    private void Awake()
    {
        next = GameObject.Find("MenuCntrl");
    }
    // Use this for initialization

    void OnMouseDown()
    {
        next.GetComponent<MenuController>().hasNext = true;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
