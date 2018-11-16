using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainLightController : MonoBehaviour {

    public Color32 redColor = new Color32(255, 0, 0, 255);
    public Color32 yellowColor = new Color32(255, 255, 0, 255);
    public Color32 greenColor = new Color32(0, 255, 0, 255);
    public Color32 blueColor = new Color32(0, 0, 255, 255);
    public Color32 orangeColor = new Color32(255, 127, 0, 255);
    public Color32 violetColor = new Color32(75, 0, 130, 255);
    public Color32 pinkColor = new Color32(228, 35, 157, 255);
    public Color32 whiteColor = Color.white;
    public Color32 blackColor = Color.black;
    public Color32 lerpedColor;
    public Color32 outColor;
    public Color32 inColor;
    public float t = 0.0f;

    void Start()
    {
       StartCoroutine(ScreenPlay());
    }

    IEnumerator ScreenPlay()
    {
        outColor = blackColor;
        inColor = whiteColor;
        yield return new WaitForSeconds(1.5f);
        t = 0.0f;
        outColor = whiteColor;
        inColor = redColor;
        yield return new WaitForSeconds(1.5f);
        while (true)
        {
            t = 0.0f;
            outColor = redColor;
            inColor = yellowColor;
            yield return new WaitForSeconds(1.5f);
            t = 0.0f;
            outColor = yellowColor;
            inColor = greenColor;
            yield return new WaitForSeconds(1.5f);
            t = 0.0f;
            outColor = greenColor;
            inColor = blueColor;
            yield return new WaitForSeconds(1.5f);
            t = 0.0f;
            outColor = blueColor;
            inColor = orangeColor;
            yield return new WaitForSeconds(1.5f);
            t = 0.0f;
            outColor = orangeColor;
            inColor = violetColor;
            yield return new WaitForSeconds(1.5f);
            t = 0.0f;
            outColor = violetColor;
            inColor = pinkColor;
            yield return new WaitForSeconds(1.5f);
            t = 0.0f;
            outColor = pinkColor;
            inColor = redColor;
            yield return new WaitForSeconds(1.5f);
        }






    }
    // Update is called once per frame
    void Update () {

        t += 0.66f * Time.deltaTime;
        lerpedColor = Color32.Lerp(outColor, inColor, t);
        GetComponent<Light>().color = lerpedColor;

        // Mathf.MoveTowards(0, -4f, 0.5f * Time.time);
    }
   
}
