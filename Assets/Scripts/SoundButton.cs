using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundButton : MonoBehaviour {

    public GameObject[] bulbs = new GameObject[9];
    public GameObject[] soundAnim = new GameObject[4];
    public string sound;
    private void Update()
    {
        sound = PlayerPrefs.GetString("sound");
    }
    private void Start()
    {
        if (PlayerPrefs.GetString("sound") != "no")
        {
            GameObject.Find("BackSound").GetComponent<AudioSource>().volume = 1;
            for (int i = 0; i < 9; i++)
            {
                if (i > 4)
                {
                    bulbs[i].SetActive(true);
                    continue;
                }

                if (i > 3)
                    continue;
                else
                    soundAnim[i].GetComponent<Animator>().SetBool("Scale", true);
            }
        }
    }
    private void OnMouseUpAsButton()
    {
        if (PlayerPrefs.GetString("sound") != "no")
        {

            PlayerPrefs.SetString("sound", "no");
            GameObject.Find("BackSound").GetComponent<AudioSource>().volume = 0;
            for (int i = 0; i < 9; i++)
            {
                bulbs[i].SetActive(false);
                if (i > 3)
                    continue;
                else
                    soundAnim[i].GetComponent<Animator>().SetBool("Scale", false);
            }
        }
        else// (PlayerPrefs.GetString("sound") == "no")
        {

            PlayerPrefs.SetString("sound", "yes");
            GameObject.Find("BackSound").GetComponent<AudioSource>().volume = 1;
            for (int i = 0; i < 9; i++)
            {
                if (i > 4)
                {
                    bulbs[i].SetActive(true);
                    continue;
                }

                if (i > 3)
                    continue;
                else
                    soundAnim[i].GetComponent<Animator>().SetBool("Scale", true);
            }
        }
    }
}
