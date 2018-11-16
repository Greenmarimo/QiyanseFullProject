using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricRamController : MonoBehaviour {

	// Use this for initialization

    public Animator animator;
    public TextDet textDet;
    public SpriteRenderer spriteRenderer;
    public GarlandColorController garlandColorController;
    public GameController gameController;
    public SpriteRenderer gameObjectGetSprite;


    private void Awake()
    {
        textDet = GameObject.Find("ColorText").GetComponent<TextDet>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        garlandColorController = GameObject.Find("garlands").GetComponent<GarlandColorController>();
        gameController = GameObject.Find("Game Controller").GetComponent<GameController>();
        gameObjectGetSprite = gameObject.GetComponent<SpriteRenderer>();
    }

    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        gameObjectGetSprite.color = garlandColorController.larpedColor;

        if(textDet.GetText.sprite.name == "RED")
        {
            animator.SetBool("BlueInYellow", false);
            animator.SetBool("BlueInPink", false);
            animator.SetBool("BlueInGreen", false);
            animator.SetBool("BlueInViolet", false);
            animator.SetBool("BlueInRed", true);
            animator.SetBool("BlueInOrange", false);
            animator.SetBool("YellowInBlue", false);
            animator.SetBool("YellowInPink", false);
            animator.SetBool("YellowInGreen", false);
            animator.SetBool("YellowInViolet", false);
            animator.SetBool("YellowInRed", true);
            animator.SetBool("YellowInOrange", false);
            animator.SetBool("PinkInBlue", false);
            animator.SetBool("PinkInYellow", false);
            animator.SetBool("PinkInGreen", false);
            animator.SetBool("PinkInViolet", false);
            animator.SetBool("PinkInRed", true);
            animator.SetBool("PinkInOrange", false);
            animator.SetBool("GreenInBlue", false);
            animator.SetBool("GreenInYellow", false);
            animator.SetBool("GreenInPink", false);
            animator.SetBool("GreenInViolet", false);
            animator.SetBool("GreenInRed", true);
            animator.SetBool("GreenInOrange", false);
            animator.SetBool("VioletInBlue", false);
            animator.SetBool("VioletInYellow", false);
            animator.SetBool("VioletInPink", false);
            animator.SetBool("VioletInGreen", false);
            animator.SetBool("VioletInRed", true);
            animator.SetBool("VioletInOrange", false);
            animator.SetBool("RedInBlue", false);
            animator.SetBool("RedInYellow", false);
            animator.SetBool("RedInPink", false);
            animator.SetBool("RedInGreen", false);
            animator.SetBool("RedInViolet", false);
            animator.SetBool("RedInOrange", false);
            animator.SetBool("OrangeInBlue", false);
            animator.SetBool("OrangeInYellow", false);
            animator.SetBool("OrangeInPink", false);
            animator.SetBool("OrangeInGreen", false);
            animator.SetBool("OrangeInViolet", false);
            animator.SetBool("OrangeInRed", true);

        }
        if (textDet.GetText.sprite.name == "YELLOW")
        {
            animator.SetBool("BlueInYellow", true);
            animator.SetBool("BlueInPink", false);
            animator.SetBool("BlueInGreen", false);
            animator.SetBool("BlueInViolet", false);
            animator.SetBool("BlueInRed", false);
            animator.SetBool("BlueInOrange", false);
            animator.SetBool("YellowInBlue", false);
            animator.SetBool("YellowInPink", false);
            animator.SetBool("YellowInGreen", false);
            animator.SetBool("YellowInViolet", false);
            animator.SetBool("YellowInRed", false);
            animator.SetBool("YellowInOrange", false);
            animator.SetBool("PinkInBlue", false);
            animator.SetBool("PinkInYellow", true);
            animator.SetBool("PinkInGreen", false);
            animator.SetBool("PinkInViolet", false);
            animator.SetBool("PinkInRed", false);
            animator.SetBool("PinkInOrange", false);
            animator.SetBool("GreenInBlue", false);
            animator.SetBool("GreenInYellow", true);
            animator.SetBool("GreenInPink", false);
            animator.SetBool("GreenInViolet", false);
            animator.SetBool("GreenInRed", false);
            animator.SetBool("GreenInOrange", false);
            animator.SetBool("VioletInBlue", false);
            animator.SetBool("VioletInYellow", true);
            animator.SetBool("VioletInPink", false);
            animator.SetBool("VioletInGreen", false);
            animator.SetBool("VioletInRed", false);
            animator.SetBool("VioletInOrange", false);
            animator.SetBool("RedInBlue", false);
            animator.SetBool("RedInYellow", true);
            animator.SetBool("RedInPink", false);
            animator.SetBool("RedInGreen", false);
            animator.SetBool("RedInViolet", false);
            animator.SetBool("RedInOrange", false);
            animator.SetBool("OrangeInBlue", false);
            animator.SetBool("OrangeInYellow", true);
            animator.SetBool("OrangeInPink", false);
            animator.SetBool("OrangeInGreen", false);
            animator.SetBool("OrangeInViolet", false);
            animator.SetBool("OrangeInRed", false);
        }
        if (textDet.GetText.sprite.name == "GREEN")
        {
            animator.SetBool("BlueInYellow", false);
            animator.SetBool("BlueInPink", false);
            animator.SetBool("BlueInGreen", true);
            animator.SetBool("BlueInViolet", false);
            animator.SetBool("BlueInRed", false);
            animator.SetBool("BlueInOrange", false);
            animator.SetBool("YellowInBlue", false);
            animator.SetBool("YellowInPink", false);
            animator.SetBool("YellowInGreen", true);
            animator.SetBool("YellowInViolet", false);
            animator.SetBool("YellowInRed", false);
            animator.SetBool("YellowInOrange", false);
            animator.SetBool("PinkInBlue", false);
            animator.SetBool("PinkInYellow", false);
            animator.SetBool("PinkInGreen", true);
            animator.SetBool("PinkInViolet", false);
            animator.SetBool("PinkInRed", false);
            animator.SetBool("PinkInOrange", false);
            animator.SetBool("GreenInBlue", false);
            animator.SetBool("GreenInYellow", false);
            animator.SetBool("GreenInPink", false);
            animator.SetBool("GreenInViolet", false);
            animator.SetBool("GreenInRed", false);
            animator.SetBool("GreenInOrange", false);
            animator.SetBool("VioletInBlue", false);
            animator.SetBool("VioletInYellow", false);
            animator.SetBool("VioletInPink", false);
            animator.SetBool("VioletInGreen", true);
            animator.SetBool("VioletInRed", false);
            animator.SetBool("VioletInOrange", false);
            animator.SetBool("RedInBlue", false);
            animator.SetBool("RedInYellow", false);
            animator.SetBool("RedInPink", false);
            animator.SetBool("RedInGreen", true);
            animator.SetBool("RedInViolet", false);
            animator.SetBool("RedInOrange", false);
            animator.SetBool("OrangeInBlue", false);
            animator.SetBool("OrangeInYellow", false);
            animator.SetBool("OrangeInPink", false);
            animator.SetBool("OrangeInGreen", true);
            animator.SetBool("OrangeInViolet", false);
            animator.SetBool("OrangeInRed", false);
        }
        if (textDet.GetText.sprite.name == "BLUE")
        {
            animator.SetBool("BlueInYellow", false);
            animator.SetBool("BlueInPink", false);
            animator.SetBool("BlueInGreen", false);
            animator.SetBool("BlueInViolet", false);
            animator.SetBool("BlueInRed", false);
            animator.SetBool("BlueInOrange", false);
            animator.SetBool("YellowInBlue", true);
            animator.SetBool("YellowInPink", false);
            animator.SetBool("YellowInGreen", false);
            animator.SetBool("YellowInViolet", false);
            animator.SetBool("YellowInRed", false);
            animator.SetBool("YellowInOrange", false);
            animator.SetBool("PinkInBlue", true);
            animator.SetBool("PinkInYellow", false);
            animator.SetBool("PinkInGreen", false);
            animator.SetBool("PinkInViolet", false);
            animator.SetBool("PinkInRed", false);
            animator.SetBool("PinkInOrange", false);
            animator.SetBool("GreenInBlue", true);
            animator.SetBool("GreenInYellow", false);
            animator.SetBool("GreenInPink", false);
            animator.SetBool("GreenInViolet", false);
            animator.SetBool("GreenInRed", false);
            animator.SetBool("GreenInOrange", false);
            animator.SetBool("VioletInBlue", true);
            animator.SetBool("VioletInYellow", false);
            animator.SetBool("VioletInPink", false);
            animator.SetBool("VioletInGreen", false);
            animator.SetBool("VioletInRed", false);
            animator.SetBool("VioletInOrange", false);
            animator.SetBool("RedInBlue", true);
            animator.SetBool("RedInYellow", false);
            animator.SetBool("RedInPink", false);
            animator.SetBool("RedInGreen", false);
            animator.SetBool("RedInViolet", false);
            animator.SetBool("RedInOrange", false);
            animator.SetBool("OrangeInBlue", true);
            animator.SetBool("OrangeInYellow", false);
            animator.SetBool("OrangeInPink", false);
            animator.SetBool("OrangeInGreen", false);
            animator.SetBool("OrangeInViolet", false);
            animator.SetBool("OrangeInRed", false);
        }
        if (textDet.GetText.sprite.name == "ORANGE")
        {
            animator.SetBool("BlueInYellow", false);
            animator.SetBool("BlueInPink", false);
            animator.SetBool("BlueInGreen", false);
            animator.SetBool("BlueInViolet", false);
            animator.SetBool("BlueInRed", false);
            animator.SetBool("BlueInOrange", true);
            animator.SetBool("YellowInBlue", false);
            animator.SetBool("YellowInPink", false);
            animator.SetBool("YellowInGreen", false);
            animator.SetBool("YellowInViolet", false);
            animator.SetBool("YellowInRed", false);
            animator.SetBool("YellowInOrange", true);
            animator.SetBool("PinkInBlue", false);
            animator.SetBool("PinkInYellow", false);
            animator.SetBool("PinkInGreen", false);
            animator.SetBool("PinkInViolet", false);
            animator.SetBool("PinkInRed", false);
            animator.SetBool("PinkInOrange", true);
            animator.SetBool("GreenInBlue", false);
            animator.SetBool("GreenInYellow", false);
            animator.SetBool("GreenInPink", false);
            animator.SetBool("GreenInViolet", false);
            animator.SetBool("GreenInRed", false);
            animator.SetBool("GreenInOrange", true);
            animator.SetBool("VioletInBlue", false);
            animator.SetBool("VioletInYellow", false);
            animator.SetBool("VioletInPink", false);
            animator.SetBool("VioletInGreen", false);
            animator.SetBool("VioletInRed", false);
            animator.SetBool("VioletInOrange", true);
            animator.SetBool("RedInBlue", false);
            animator.SetBool("RedInYellow", false);
            animator.SetBool("RedInPink", false);
            animator.SetBool("RedInGreen", false);
            animator.SetBool("RedInViolet", false);
            animator.SetBool("RedInOrange", true);
            animator.SetBool("OrangeInBlue", false);
            animator.SetBool("OrangeInYellow", false);
            animator.SetBool("OrangeInPink", false);
            animator.SetBool("OrangeInGreen", false);
            animator.SetBool("OrangeInViolet", false);
            animator.SetBool("OrangeInRed", false);
        }
        if (textDet.GetText.sprite.name == "VIOLET")
        {
            animator.SetBool("BlueInYellow", false);
            animator.SetBool("BlueInPink", false);
            animator.SetBool("BlueInGreen", false);
            animator.SetBool("BlueInViolet", true);
            animator.SetBool("BlueInRed", false);
            animator.SetBool("BlueInOrange", false);
            animator.SetBool("YellowInBlue", false);
            animator.SetBool("YellowInPink", false);
            animator.SetBool("YellowInGreen", false);
            animator.SetBool("YellowInViolet", true);
            animator.SetBool("YellowInRed", false);
            animator.SetBool("YellowInOrange", false);
            animator.SetBool("PinkInBlue", false);
            animator.SetBool("PinkInYellow", false);
            animator.SetBool("PinkInGreen", false);
            animator.SetBool("PinkInViolet", true);
            animator.SetBool("PinkInRed", false);
            animator.SetBool("PinkInOrange", false);
            animator.SetBool("GreenInBlue", false);
            animator.SetBool("GreenInYellow", false);
            animator.SetBool("GreenInPink", false);
            animator.SetBool("GreenInViolet", true);
            animator.SetBool("GreenInRed", false);
            animator.SetBool("GreenInOrange", false);
            animator.SetBool("VioletInBlue", false);
            animator.SetBool("VioletInYellow", false);
            animator.SetBool("VioletInPink", false);
            animator.SetBool("VioletInGreen", false);
            animator.SetBool("VioletInRed", false);
            animator.SetBool("VioletInOrange", false);
            animator.SetBool("RedInBlue", false);
            animator.SetBool("RedInYellow", false);
            animator.SetBool("RedInPink", false);
            animator.SetBool("RedInGreen", false);
            animator.SetBool("RedInViolet", true);
            animator.SetBool("RedInOrange", false);
            animator.SetBool("OrangeInBlue", false);
            animator.SetBool("OrangeInYellow", false);
            animator.SetBool("OrangeInPink", false);
            animator.SetBool("OrangeInGreen", false);
            animator.SetBool("OrangeInViolet", true);
            animator.SetBool("OrangeInRed", false);
        }
        if (textDet.GetText.sprite.name == "PINK")
        {
            animator.SetBool("BlueInYellow", false);
            animator.SetBool("BlueInPink", true);
            animator.SetBool("BlueInGreen", false);
            animator.SetBool("BlueInViolet", false);
            animator.SetBool("BlueInRed", false);
            animator.SetBool("BlueInOrange", false);
            animator.SetBool("YellowInBlue", false);
            animator.SetBool("YellowInPink", true);
            animator.SetBool("YellowInGreen", false);
            animator.SetBool("YellowInViolet", false);
            animator.SetBool("YellowInRed", false);
            animator.SetBool("YellowInOrange", false);
            animator.SetBool("PinkInBlue", false);
            animator.SetBool("PinkInYellow", false);
            animator.SetBool("PinkInGreen", false);
            animator.SetBool("PinkInViolet", false);
            animator.SetBool("PinkInRed", false);
            animator.SetBool("PinkInOrange", false);
            animator.SetBool("GreenInBlue", false);
            animator.SetBool("GreenInYellow", false);
            animator.SetBool("GreenInPink", true);
            animator.SetBool("GreenInViolet", false);
            animator.SetBool("GreenInRed", false);
            animator.SetBool("GreenInOrange", false);
            animator.SetBool("VioletInBlue", false);
            animator.SetBool("VioletInYellow", false);
            animator.SetBool("VioletInPink", true);
            animator.SetBool("VioletInGreen", false);
            animator.SetBool("VioletInRed", false);
            animator.SetBool("VioletInOrange", false);
            animator.SetBool("RedInBlue", false);
            animator.SetBool("RedInYellow", false);
            animator.SetBool("RedInPink", true);
            animator.SetBool("RedInGreen", false);
            animator.SetBool("RedInViolet", false);
            animator.SetBool("RedInOrange", false);
            animator.SetBool("OrangeInBlue", false);
            animator.SetBool("OrangeInYellow", false);
            animator.SetBool("OrangeInPink", true);
            animator.SetBool("OrangeInGreen", false);
            animator.SetBool("OrangeInViolet", false);
            animator.SetBool("OrangeInRed", false);
        }



    }
}
