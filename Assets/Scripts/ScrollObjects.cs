using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObjects : MonoBehaviour {

    public float speed, checkPos =0f;
    private RectTransform rec;
    public bool hasScroll = false;
	// Use this for initialization
	void Start () {
        rec = GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void Update () {
        if (hasScroll)
        {
            if (rec.offsetMin.y != checkPos)
            {
                rec.offsetMin += new Vector2(rec.offsetMin.x, speed);
                rec.offsetMax += new Vector2(rec.offsetMax.x, speed);
            }
        }
		
	}
}
