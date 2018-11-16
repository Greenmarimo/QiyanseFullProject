﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public bool lose = false;
    public bool hasNext = false;
    public GameObject Eye;
    public Transform MainDisk;
    private GameObject[] blocks = new GameObject[7];
    public GameObject[] sclera = new GameObject[7];
    public Sprite[] EyesTexture = new Sprite[7];
    public int[] array = {0,1,2,3,4,5,6};
    public TextDet colorText;
    public int score;
    public int count = 0;
    public Text scoreText;
    public Timer timer;
    public GameObject pLost;
    public GameObject animLost;
    public GameObject garlandLost;
    public ColorEdgeController colorEdge;
    public Animator[] GarlandAnim = new Animator[7];
    private ScrollObjects scrollObjects;
    public GameObject electricText;
    public GameObject colorTextObject;
    public bool hasTransition = false;
    private Renderer rendererBackGround;



    private void Awake()
    {
        
       
        timer = GameObject.Find("Timer").GetComponent<Timer>();
        scoreText = GameObject.Find("Score").GetComponent<Text>();
        colorTextObject = GameObject.Find("ColorText");
        colorText = GameObject.Find("ColorText").GetComponent<TextDet>();
        colorText.hasNext = false;
        rendererBackGround = GameObject.Find("BackGround").GetComponent<Renderer>();
        sclera[0] = GameObject.Find("Sclera");
        sclera[1] = GameObject.Find("Sclera (1)");
        sclera[2] = GameObject.Find("Sclera (2)");
        sclera[3] = GameObject.Find("Sclera (3)");
        sclera[4] = GameObject.Find("Sclera (4)");
        sclera[5] = GameObject.Find("Sclera (5)");
        sclera[6] = GameObject.Find("Sclera (6)");
       /* GarlandAnim[0] = GameObject.Find("garlandLight_0").GetComponent<Animator>();
        GarlandAnim[1] = GameObject.Find("garlandLight_1").GetComponent<Animator>();
        GarlandAnim[2] = GameObject.Find("garlandLight_2").GetComponent<Animator>();
        GarlandAnim[3] = GameObject.Find("garlandLight_3").GetComponent<Animator>();
        GarlandAnim[4] = GameObject.Find("garlandLight_4").GetComponent<Animator>();
        GarlandAnim[5] = GameObject.Find("garlandLight_5").GetComponent<Animator>();
        GarlandAnim[6] = GameObject.Find("garlandLight_6").GetComponent<Animator>();
        */
        scrollObjects = GameObject.Find("Score").GetComponent<ScrollObjects>();
 

    }
    // Use this for initialization
    void Start()
    {
        rendererBackGround.sharedMaterial.SetVector("_HSVAAdjust", new Vector4(0, 0, 0, 0));
        StartCoroutine(ScreenPlay());
    }

    IEnumerator ScreenPlay()
    {
        yield return new WaitForSeconds(2.5f);
        colorText.hasNext = true;
        electricText.SetActive(true);
        timer.hasTime = true;
        colorEdge.hasNext = true;
    }

    // Update is called once per frame
    void Update () {        
        if(score < 10)
        {
            scoreText.text = "00" + score.ToString();
        }
        else if (score >= 10 && score < 100)
        {
            scoreText.text = "0" + score.ToString();
        }
        else if (score >= 100)
        {
            scoreText.text = score.ToString();
        }
        if (hasNext && !lose )
        {
            
            for (int i = 0; i < 7; i++)
            {
                Destroy(blocks[i]);
            }
            if (!hasTransition)
            {
                Next();
            }
            
        }
        if (lose)
        {
            PlayerLose();
        }
    }
    void Next()
    {
        hasNext = false;

        timer.timerTime = timer.maxTimerTime;
        var rand = new System.Random();
        for (int i = array.Length - 1; i >= 0; i--)
        {
            int j = rand.Next(i);
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        for (int i = 0; i < 7; i++)
        {
            blocks[i] = Instantiate(Eye, new Vector3(sclera[i].transform.position.x, sclera[i].transform.position.y, sclera[i].transform.position.z - 0.2f), Quaternion.identity) as GameObject;
            blocks[i].transform.SetParent(MainDisk);
            blocks[i].GetComponent<SpriteRenderer>().sprite = EyesTexture[array[i]];
            if (blocks[i].GetComponent<SpriteRenderer>().sprite.name == colorText.textColorName[0].name && score <6)
            {
                blocks[i].GetComponent<RightObjects>().right = true;
            }
            if (blocks[i].GetComponent<SpriteRenderer>().sprite.name == colorText.textColorName[0].name || blocks[i].GetComponent<SpriteRenderer>().sprite.name == colorText.textColorName[1].name && score >= 6 )
            {
                blocks[i].GetComponent<RightObjects>().right = true;
            }
            
            


        }
    }
    void PlayerLose()
    {
        for (int i = 0; i < 7; i++)
        {
            Destroy(blocks[i]);
        }
        pLost.SetActive(true);
        colorTextObject.SetActive(false);
        animLost.GetComponent<AnimationController>().lose = true;
        //garlandLost.GetComponent<GarlandColorController>().lose = true;
        scrollObjects.hasScroll = true;
        if (PlayerPrefs.GetInt("Record") < score)
        {
            PlayerPrefs.SetInt("Record", score);
        }
        
    }
}
