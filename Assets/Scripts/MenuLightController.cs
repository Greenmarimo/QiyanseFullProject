using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLightController : MonoBehaviour {

    public GameObject[] menuLights = new GameObject[5];
	void Start () {
        StartCoroutine(MenuLightCorr());
	}
	
	IEnumerator MenuLightCorr()
    {
        while (true)
        {
            for(int i = 0; i < 5; i++)
            {
                if (PlayerPrefs.GetString("sound") != "no")
                {
                    menuLights[i].SetActive(true);
                    if (i > 0)
                    {
                        menuLights[i - 1].SetActive(false);
                    }
                    else
                    {
                        menuLights[4].SetActive(false);
                    }
                }
                
                yield return new WaitForSeconds(0.4f);
            }
        }
    }
}
