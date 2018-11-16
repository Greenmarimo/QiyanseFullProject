using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

    private Animator neonDiskAnim;
    private GameObject header;
    private GameObject mainTable;
    private GameObject neonDisk;
    private GameObject neonDemon;
    private GameObject score;
    private Animator Disk;
    private Renderer rendererBackGround;
    private Vector4 nsvVector;
    public float speed;
    public bool hasNext;
    public bool startCor = true;
    // Use this for initialization
    private void Awake()
    {
        neonDiskAnim = GameObject.Find("Neon_Disk").GetComponent<Animator>();
        header = GameObject.Find("Header");
        mainTable = GameObject.Find("MainMenu");
        neonDisk = GameObject.Find("Neon_Disk");
        neonDemon = GameObject.Find("Neon_Demon");
        score = GameObject.Find("Record");
        Disk = GameObject.Find("Disk").GetComponent<Animator>();
        rendererBackGround = GameObject.Find("BackGround").GetComponent<Renderer>();
        nsvVector = new Vector4(0, 0, -0.15f, 0);

    }
    void Start()
    {
        rendererBackGround.sharedMaterial.SetVector("_HSVAAdjust", nsvVector);
    }
    IEnumerator NextScreen()
    {
        neonDiskAnim.SetBool("NextGame", true);
        yield return new WaitForSeconds(0.5f);
        Destroy(neonDisk);
        Disk.SetBool("scaleInIdleScaled", true);
        yield return new WaitForSeconds(0.2f);
        Application.LoadLevel("GamePlay");
        
    }
	
	// Update is called once per frame
	void Update () {
        if (hasNext)
        {
            Disk.SetBool("idleInScale", true);
            Destroy(score);
            if (startCor)
            {
                
                StartCoroutine(NextScreen());
                startCor = false;
            }


            header.transform.Translate(new Vector3(0, Time.deltaTime * 8, 0));
            mainTable.transform.Translate(new Vector3(0, Time.deltaTime * -8, 0));
            float step = speed * Time.deltaTime;
            nsvVector = Vector4.MoveTowards(nsvVector, new Vector4(0, 0, 0, 0), step);
            rendererBackGround.sharedMaterial.SetVector("_HSVAAdjust", nsvVector);
            if (mainTable.transform.position.y <= -7)
            {
                mainTable.SetActive(false);
            }
            if (header.transform.position.y >= 7)
            {
                header.SetActive(false);
            }
        }
	}
}
