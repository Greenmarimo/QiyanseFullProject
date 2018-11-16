using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RamColorController : MonoBehaviour {


    public SpriteRenderer neon;
    public SpriteRenderer neonBack;
    public Text TextColor1;
    public Text TextColor2;
    public Text TextColor3;

    // Use this for initialization
    private void Awake()
    {
        neon = GameObject.Find("Ram_Neon1").GetComponent<SpriteRenderer>();
        neonBack = GameObject.Find("Ram Back").GetComponent<SpriteRenderer>();
        TextColor1 = GameObject.Find("ColorText").GetComponent<Text>();
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
            neon.color = TextColor1.color;
            neonBack.color = TextColor1.color;
        
	}
}
