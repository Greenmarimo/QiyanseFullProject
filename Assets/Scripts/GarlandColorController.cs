using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarlandColorController : MonoBehaviour {

    // Use this for initialization
    public SpriteRenderer[] garlandLights = new SpriteRenderer[7];
    public SpriteRenderer pentagramma;
    public Color[] colorArray = new Color[6];
    public Color larpedColor;
    public GameController gameController;
    public bool hasNextColor = false;
    public float speed;




    private void Awake()
    {
        garlandLights[0] = GameObject.Find("garland0").GetComponent<SpriteRenderer>();
        garlandLights[1] = GameObject.Find("garland1").GetComponent<SpriteRenderer>();
        garlandLights[2] = GameObject.Find("garland2").GetComponent<SpriteRenderer>();
        garlandLights[3] = GameObject.Find("garland3").GetComponent<SpriteRenderer>();
        garlandLights[4] = GameObject.Find("garland4").GetComponent<SpriteRenderer>();
        garlandLights[5] = GameObject.Find("garland5").GetComponent<SpriteRenderer>();
        garlandLights[6] = GameObject.Find("garland6").GetComponent<SpriteRenderer>();
        pentagramma = GameObject.Find("Pentagramma").GetComponent<SpriteRenderer>();
        gameController = GameObject.Find("Game Controller").GetComponent<GameController>();

    }

    void Start () {
       
    }
    
	
	// Update is called once per frame
	
    void Update()
    {
        if(gameController.score == 6)
        {
            float step = speed * Time.deltaTime;
            larpedColor = Color.Lerp(larpedColor, colorArray[0], step);
            for(int i = 0; i < 7; i++)
            {
                 garlandLights[i].color = larpedColor;
            }
            pentagramma.color = larpedColor;
            
        }
        if (gameController.score == 10)
        {
            float step = speed * Time.deltaTime;
            larpedColor = Color.Lerp(larpedColor, colorArray[1], step);
            for (int i = 0; i < 7; i++)
            {
                garlandLights[i].color = larpedColor;
            }
            pentagramma.color = larpedColor;
            
        }
        if (gameController.score == 16)
        {
            float step = speed * Time.deltaTime;
            larpedColor = Color.Lerp(larpedColor, colorArray[2], step);
            for (int i = 0; i < 7; i++)
            {
                garlandLights[i].color = larpedColor;
            }
            pentagramma.color = larpedColor;
            
        }
        if (gameController.score == 20)
        {
            float step = speed * Time.deltaTime;
            larpedColor = Color.Lerp(larpedColor, colorArray[3], step);
            for (int i = 0; i < 7; i++)
            {
                garlandLights[i].color = larpedColor;
            }
            pentagramma.color = larpedColor;
            
        }
        if (gameController.score == 26)
        {
            float step = speed * Time.deltaTime;
            larpedColor = Color.Lerp(larpedColor, colorArray[4], step);
            for (int i = 0; i < 7; i++)
            {
                garlandLights[i].color = larpedColor;
            }
            pentagramma.color = larpedColor;
            
        }
        if (gameController.score == 30)
        {
            float step = speed * Time.deltaTime;
            larpedColor = Color.Lerp(larpedColor, colorArray[5], step);
            for (int i = 0; i < 7; i++)
            {
                garlandLights[i].color = larpedColor;
            }
            pentagramma.color = larpedColor;
            
        }
    }

}
