using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectToWards : MonoBehaviour {

    // Use this for initialization
    public float XPos;
    public float yPos;
    public float zPos;

    public float speed;

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(XPos, yPos, zPos), step);

    }
}
