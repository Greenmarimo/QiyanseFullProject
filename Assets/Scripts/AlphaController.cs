using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaController : MonoBehaviour {


    public bool alphaStart = false;
    public float speed;
    // Use this for initialization
    public SpriteRenderer GetColor;
    public Color32 target;

    private void Awake()
    {
        GetColor = GetComponent<SpriteRenderer>();
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (alphaStart)
        {
            float step = speed * Time.deltaTime;
            GetColor.color = Color32.Lerp(GetColor.color, target, step);
        }
	}
}
