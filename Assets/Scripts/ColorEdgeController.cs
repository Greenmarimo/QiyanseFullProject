using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorEdgeController : MonoBehaviour {

    // Use this for initialization
    public SpriteRenderer getSprite;
    public SpriteRenderer colorTextSprite;
    public TextDet textDet;
    public Sprite[] colorEdgeSprites = new Sprite[7];
    public bool hasNext = false;

    private void Awake()
    {
        colorTextSprite = GameObject.Find("ColorText").GetComponent<SpriteRenderer>();
        getSprite = GetComponent<SpriteRenderer>();
        textDet = GameObject.Find("ColorText").GetComponent<TextDet>();
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (hasNext)
        {
            if (colorTextSprite.sprite.name == "RED")
            {
                getSprite.sprite = colorEdgeSprites[0];
            }
            if (colorTextSprite.sprite.name == "YELLOW")
            {
                getSprite.sprite = colorEdgeSprites[1];
            }
            if (colorTextSprite.sprite.name == "GREEN")
            {
                getSprite.sprite = colorEdgeSprites[2];
            }
            if (colorTextSprite.sprite.name == "BLUE")
            {
                getSprite.sprite = colorEdgeSprites[3];
            }
            if (colorTextSprite.sprite.name == "ORANGE")
            {
                getSprite.sprite = colorEdgeSprites[4];
            }
            if (colorTextSprite.sprite.name == "VIOLET")
            {
                getSprite.sprite = colorEdgeSprites[5];
            }
            if (colorTextSprite.sprite.name == "PINK")
            {
                getSprite.sprite = colorEdgeSprites[6];
            }
        }
    }
}
