using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayButtons : MonoBehaviour {

    public float speed;
    public GameObject Menu;
    public Sprite buttonDown;
    public Sprite buttonUp;
    
    // Use this for initialization
    void Start () {
        speed = 5;

    }
    void OnMouseDown()
    {
        switch (gameObject.name)
        {
            case "RestartButton":
                {                    
                    GetComponent<RotateConrtoller>().speed = -140;
                    break;
                    
                }
            case "MainMenuButton":
                {
                    
                    Menu.GetComponent<SpriteRenderer>().sprite = buttonDown;
                    break;
                }
            case "Info_Layer1": 
                {
                    GetComponent<SpriteRenderer>().sprite = buttonDown;
                    break;
                }
            case "BackButton":
                {
                    transform.localScale = new Vector3(1.12f, 1.12f, 1f);
                    break;
                }
        }
    }
    private void OnMouseUp()
    {
       
        switch (gameObject.name)
        {
            case "RestartButton":
                {
                    GetComponent<RotateConrtoller>().speed = -30;
                    break;

                }
            case "MainMenuButton":
                {
                   
                    Menu.GetComponent<SpriteRenderer>().sprite = buttonUp;
                    break;
                }
            case "Info_Layer1":
                {
                    GetComponent<SpriteRenderer>().sprite = buttonUp;
                    break;
                }
            case "BackButton":
                {
                    transform.localScale = new Vector3(1f, 1f, 1f);
                    break;
                }
        }
    }
    private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "RestartButton":
                {
                    Application.LoadLevel("GamePlay");
                    break;

                }
            case "MainMenuButton":
                {
                    Application.LoadLevel("MainMenu");
                    break;
                }
            case "Info_Layer1":
                {
                    Application.LoadLevel("InfoScene");
                    break;
                }
            case "BackButton":
                {
                    Application.LoadLevel("MainMenu");
                    break;
                }
        }
    }
    
    // Update is called once per frame
    void Update () {
		
	}
}
