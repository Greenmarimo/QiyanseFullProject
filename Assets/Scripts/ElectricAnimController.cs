using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricAnimController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(ElectricCor());
	}

    IEnumerator ElectricCor()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);
    }
    // Update is called once per frame
    private void Update()
    {
        
    }
}
