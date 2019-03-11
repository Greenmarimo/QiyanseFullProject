using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float timerTime;
    public float maxTimerTime;
    public GameController gameCntrl;
    public GameObject brainLight;
    public bool hasTime = false;
    private Image GetImage;
    

    // Use this for initialization
    private void Awake()
    {
        GetImage = GetComponent<Image>();

        maxTimerTime = 7f;
        gameCntrl = GameObject.Find("Game Controller").GetComponent<GameController>();
        brainLight = GameObject.Find("BrainLight");
    }


    // Update is called once per frame
    void Update()
    {
        if (hasTime && gameCntrl.score != 0 && gameCntrl.score != 8)
        {
            Image image = GetImage;
            if(gameCntrl.score >= 8 && gameCntrl.score < 50)
            {
                maxTimerTime = 6f - Mathf.Pow(gameCntrl.score * 1.09744f,1/3);
            }
            

            image.fillAmount = timerTime / maxTimerTime;

            if (timerTime > 0)
            {
                timerTime -= Time.deltaTime;
            }
            if (timerTime <= 0)
            {
                gameCntrl.lose = true;
            }
            
        }
        

    }
}
