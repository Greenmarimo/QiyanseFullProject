using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightObjects : MonoBehaviour {

    public GameObject gameCntrl;
    public GameObject colorText;
    public TextDet textDet;
    public bool right = false;
    public NeonNovaController novaController;
    public Timer timer;
    private GameObject electric;
    public GameObject electricPref;
    public Transform MainDisk;


    // Use this for initialization

    void Awake()
    {
        gameCntrl = GameObject.Find("Game Controller");
        colorText = GameObject.Find("ColorText");
        textDet = GameObject.Find("ColorText").GetComponent<TextDet>();
        novaController = GameObject.Find("Neon Nova Controller").GetComponent<NeonNovaController>();
        timer = GameObject.Find("Timer").GetComponent<Timer>();
        MainDisk = GameObject.Find("MainDisk").GetComponent<Transform>();


    }

    

    // Update is called once per frame
    void OnMouseDown()
    {
        if (right)
        {
           
            gameCntrl.GetComponent<GameController>().score++;
            
            if (gameCntrl.GetComponent<GameController>().score > 8) { gameCntrl.GetComponent<GameController>().count++; }
            if (gameCntrl.GetComponent<GameController>().score <= 8)
            {
                colorText.GetComponent<TextDet>().hasNext = true;
                textDet.StopAllCoroutines();
            }
            else if (gameCntrl.GetComponent<GameController>().score > 8 && gameCntrl.GetComponent<GameController>().count == 2)
            {
                gameCntrl.GetComponent<GameController>().count = 0;
                colorText.GetComponent<TextDet>().hasNext = true;
                textDet.StopAllCoroutines();

            }
            electric = Instantiate(electricPref, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z - 0.2f), Quaternion.identity) as GameObject;
            electric.transform.SetParent(MainDisk);
            Destroy(gameObject);
        }
        else
        {
            //StartCoroutine(NeonCorr());
            gameCntrl.GetComponent<GameController>().lose = true;
            
        }

    }
}

