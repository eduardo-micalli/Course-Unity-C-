using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manipulacaosprites : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(new Vector3(0.1f, 0, 0));
        transform.Rotate(new Vector3(0,0,-0.5f));
        transform.localScale += new Vector3(0.1f,0.1f,0);
	}
}
