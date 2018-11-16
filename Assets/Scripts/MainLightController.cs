using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLightController : MonoBehaviour {


    private Light getLight;
    public GameController gameController;
    public GameObject gam;
    public float speed;


    private void Awake()
    {
        getLight = GetComponent<Light>();
        gam = GameObject.Find("Game Controller");
        gameController = GameObject.Find("Game Controller").GetComponent<GameController>();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gameController.lose)
        {
            float step = speed * Time.deltaTime;
            getLight.intensity = Mathf.MoveTowards(getLight.intensity, 0, step);
        }

	}
}
