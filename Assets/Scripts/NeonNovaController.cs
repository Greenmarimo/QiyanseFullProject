using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeonNovaController : MonoBehaviour {

    // Use this for initialization

    private GameObject neonNova;
    public GameObject neonNovaPref;
    public GameObject mainDisk;
    public Transform mainDiskTransform;
    public Sprite redNeonNova;
    public Sprite greenNeonNova;
    public bool redNova;
    public bool greenNova;
    public bool startCor;
    void Start () {
        mainDisk = GameObject.Find("MainDisk");
        mainDiskTransform = GameObject.Find("MainDisk").transform;
    }

    IEnumerator NeonCorr()
    {

        if (greenNova)
        {
            greenNova = false;
            neonNova = Instantiate(neonNovaPref, new Vector3(0, 0, -0.5f), Quaternion.identity) as GameObject;
            neonNova.transform.SetParent(mainDiskTransform);
            neonNova.transform.rotation = mainDisk.transform.rotation;
            neonNova.GetComponent<SpriteRenderer>().sprite = greenNeonNova;
        }
        if (redNova)
        {
            redNova = false;
            neonNova = Instantiate(neonNovaPref, new Vector3(0, 0,  -0.5f), Quaternion.identity) as GameObject;
            neonNova.transform.SetParent(mainDiskTransform);
            neonNova.transform.rotation = mainDisk.transform.rotation;
            neonNova.GetComponent<SpriteRenderer>().sprite = redNeonNova;
        }
        yield return new WaitForSeconds(0.4f);
        Destroy(neonNova);
    }
    private void Update()
    {
        if (startCor)
        {
            startCor = false;
            StartCoroutine(NeonCorr());
        }
    }
    // Update is called once per frame
}
