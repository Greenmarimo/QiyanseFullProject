using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateConrtoller : MonoBehaviour {


    public float speed;
    public bool hasRotate = false;


    void Start()
    {
       // gameController = GameObject.Find("Game Controller").GetComponent<GameController>();

    }

    // Update is called once per frame
    void Update()
    {

        if (hasRotate)
        {
           if(gameObject.name == "MainDisk")
            {
               
                speed = Mathf.MoveTowards(0, -4f, 0.5f * Time.time);
                transform.Rotate(new Vector3(0, 0, 2.5f * speed * Time.deltaTime));
            }
           else
           {
                transform.Rotate(new Vector3(0, 0, 2.5f * speed * Time.deltaTime));
           }
        }
        

    }

}
